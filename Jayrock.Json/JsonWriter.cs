using System;
using System.Collections;
using System.Globalization;

namespace Jayrock.Json
{
	public abstract class JsonWriter : IDisposable
	{
		public abstract int Depth
		{
			get;
		}

		public abstract int Index
		{
			get;
		}

		public abstract JsonWriterBracket Bracket
		{
			get;
		}

		public virtual event EventHandler Disposed;

		public abstract void WriteStartObject();

		public abstract void WriteEndObject();

		public abstract void WriteMember(string name);

		public abstract void WriteStartArray();

		public abstract void WriteEndArray();

		public abstract void WriteString(string value);

		public abstract void WriteNumber(string value);

		public abstract void WriteBoolean(bool value);

		public abstract void WriteNull();

		public virtual void Flush()
		{
		}

		public virtual void Close()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public void WriteNumber(byte value)
		{
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(short value)
		{
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(int value)
		{
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(long value)
		{
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(decimal value)
		{
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(float value)
		{
			if (float.IsNaN(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteNumber(double value)
		{
			if (double.IsNaN(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			WriteNumber(value.ToString(CultureInfo.InvariantCulture));
		}

		public void WriteStringArray(IEnumerable values)
		{
			if (values == null)
			{
				WriteNull();
				return;
			}
			WriteStartArray();
			foreach (object value in values)
			{
				if (JsonNull.LogicallyEquals(value))
				{
					WriteNull();
				}
				else
				{
					WriteString(value.ToString());
				}
			}
			WriteEndArray();
		}

		public void WriteStringArray(params string[] values)
		{
			if (values == null)
			{
				WriteNull();
				return;
			}
			WriteStartArray();
			foreach (string text in values)
			{
				if (JsonNull.LogicallyEquals(text))
				{
					WriteNull();
				}
				else
				{
					WriteString(text);
				}
			}
			WriteEndArray();
		}

		public virtual void WriteFromReader(JsonReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (!reader.MoveToContent())
			{
				return;
			}
			if (reader.TokenClass == JsonTokenClass.String)
			{
				WriteString(reader.Text);
			}
			else if (reader.TokenClass == JsonTokenClass.Number)
			{
				WriteNumber(reader.Text);
			}
			else if (reader.TokenClass == JsonTokenClass.Boolean)
			{
				WriteBoolean(reader.Text == "true");
			}
			else if (reader.TokenClass == JsonTokenClass.Null)
			{
				WriteNull();
			}
			else if (reader.TokenClass == JsonTokenClass.Array)
			{
				WriteStartArray();
				reader.Read();
				while (reader.TokenClass != JsonTokenClass.EndArray)
				{
					WriteFromReader(reader);
				}
				WriteEndArray();
			}
			else
			{
				if (reader.TokenClass != JsonTokenClass.Object)
				{
					throw new JsonException($"{reader.TokenClass} not expected.");
				}
				reader.Read();
				WriteStartObject();
				while (reader.TokenClass != JsonTokenClass.EndObject)
				{
					WriteMember(reader.ReadMember());
					WriteFromReader(reader);
				}
				WriteEndObject();
			}
			reader.Read();
		}

		public void AutoComplete()
		{
			if (Depth == 0)
			{
				throw new InvalidOperationException();
			}
			if (Bracket == JsonWriterBracket.Member)
			{
				WriteNull();
			}
			while (true)
			{
				if (Depth <= 0)
				{
					return;
				}
				if (Bracket == JsonWriterBracket.Object)
				{
					WriteEndObject();
					continue;
				}
				if (Bracket != JsonWriterBracket.Array)
				{
					break;
				}
				WriteEndArray();
			}
			throw new Exception("Implementation error.");
		}

		void IDisposable.Dispose()
		{
			Close();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				OnDisposed(EventArgs.Empty);
			}
		}

		private void OnDisposed(EventArgs e)
		{
			this.Disposed?.Invoke(this, e);
		}
	}
}
