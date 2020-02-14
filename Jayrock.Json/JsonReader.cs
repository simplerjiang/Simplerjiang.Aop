using System;

namespace Jayrock.Json
{
	public abstract class JsonReader : IDisposable
	{
		public abstract JsonToken Token
		{
			get;
		}

		public JsonTokenClass TokenClass => Token.Class;

		public string Text => Token.Text;

		public abstract int Depth
		{
			get;
		}

		public bool EOF => TokenClass == JsonTokenClass.EOF;

		public virtual event EventHandler Disposed;

		public abstract bool Read();

		public virtual void Close()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public override string ToString()
		{
			return Token.ToString();
		}

		public string ReadToken(JsonTokenClass token)
		{
			int depth = Depth;
			if (!token.IsTerminator)
			{
				MoveToContent();
			}
			string result;
			if (depth == 0 && TokenClass == JsonTokenClass.Array && (token.IsScalar || token == JsonTokenClass.Null))
			{
				Read();
				result = ReadToken(token);
				ReadToken(JsonTokenClass.EndArray);
			}
			else
			{
				if (TokenClass != token)
				{
					throw new JsonException($"Found {TokenClass} where {token} was expected.");
				}
				result = Text;
				Read();
			}
			return result;
		}

		public string ReadString()
		{
			return ReadToken(JsonTokenClass.String);
		}

		public bool ReadBoolean()
		{
			return ReadToken(JsonTokenClass.Boolean) == "true";
		}

		public JsonNumber ReadNumber()
		{
			return new JsonNumber(ReadToken(JsonTokenClass.Number));
		}

		public void ReadNull()
		{
			ReadToken(JsonTokenClass.Null);
		}

		public string ReadMember()
		{
			return ReadToken(JsonTokenClass.Member);
		}

		public void StepOut()
		{
			int depth = Depth;
			if (depth == 0)
			{
				throw new InvalidOperationException();
			}
			while (Depth > depth || (TokenClass != JsonTokenClass.EndObject && TokenClass != JsonTokenClass.EndArray))
			{
				Read();
			}
			Read();
		}

		public void Skip()
		{
			if (MoveToContent())
			{
				if (TokenClass == JsonTokenClass.Object || TokenClass == JsonTokenClass.Array)
				{
					StepOut();
				}
				else if (TokenClass == JsonTokenClass.Member)
				{
					Read();
					Skip();
				}
				else
				{
					Read();
				}
			}
		}

		public bool MoveToContent()
		{
			if (!EOF)
			{
				if (TokenClass.IsTerminator)
				{
					return Read();
				}
				return true;
			}
			return false;
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
