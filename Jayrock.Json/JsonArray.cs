using Jayrock.Json.Conversion;
using System;
using System.Collections;
using System.Globalization;

namespace Jayrock.Json
{
	[Serializable]
	public class JsonArray : CollectionBase, IJsonImportable, IJsonExportable
	{
		public virtual object this[int index]
		{
			get
			{
				return base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		public int Length => base.Count;

		public JsonArray()
		{
		}

		public JsonArray(IEnumerable collection)
		{
			foreach (object item in collection)
			{
				base.InnerList.Add(item);
			}
		}

		public JsonArray Put(object value)
		{
			Add(value);
			return this;
		}

		public virtual void Add(object value)
		{
			base.InnerList.Add(value);
		}

		public virtual void Remove(object value)
		{
			base.InnerList.Remove(value);
		}

		public virtual bool Contains(object value)
		{
			return base.InnerList.Contains(value);
		}

		public virtual int IndexOf(object value)
		{
			return base.InnerList.IndexOf(value);
		}

		public virtual bool HasValueAt(int index)
		{
			return this[index] != null;
		}

		public virtual object GetValue(int index)
		{
			return GetValue(index, null);
		}

		public virtual object GetValue(int index, object defaultValue)
		{
			object obj = this[index];
			return (obj != null) ? obj : defaultValue;
		}

		public virtual bool GetBoolean(int index)
		{
			return GetBoolean(index, defaultValue: false);
		}

		public virtual bool GetBoolean(int index, bool defaultValue)
		{
			object value = GetValue(index);
			if (value == null)
			{
				return defaultValue;
			}
			return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
		}

		public virtual double GetDouble(int index)
		{
			return GetDouble(index, float.NaN);
		}

		public virtual double GetDouble(int index, float defaultValue)
		{
			object value = GetValue(index);
			if (value == null)
			{
				return defaultValue;
			}
			return Convert.ToDouble(value, CultureInfo.InvariantCulture);
		}

		public virtual int GetInt32(int index)
		{
			return GetInt32(index, 0);
		}

		public virtual int GetInt32(int index, int defaultValue)
		{
			object value = GetValue(index);
			if (value == null)
			{
				return defaultValue;
			}
			return Convert.ToInt32(value, CultureInfo.InvariantCulture);
		}

		public virtual string GetString(int index)
		{
			return GetString(index, string.Empty);
		}

		public virtual string GetString(int index, string defaultValue)
		{
			object value = GetValue(index);
			if (value == null)
			{
				return defaultValue;
			}
			return value.ToString();
		}

		public virtual JsonArray GetArray(int index)
		{
			return (JsonArray)GetValue(index);
		}

		public virtual JsonObject GetObject(int index)
		{
			return (JsonObject)GetValue(index);
		}

		public override string ToString()
		{
			JsonTextWriter jsonTextWriter = new JsonTextWriter();
			Export(jsonTextWriter);
			return jsonTextWriter.ToString();
		}

		public virtual void Export(JsonWriter writer)
		{
			Export(new ExportContext(), writer);
		}

		void IJsonExportable.Export(ExportContext context, JsonWriter writer)
		{
			Export(context, writer);
		}

		protected virtual void Export(ExportContext context, JsonWriter writer)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteStartArray();
			IEnumerator enumerator = GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					context.Export(current, writer);
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			writer.WriteEndArray();
		}

		public virtual void Import(JsonReader reader)
		{
			Import(new ImportContext(), reader);
		}

		void IJsonImportable.Import(ImportContext context, JsonReader reader)
		{
			Import(context, reader);
		}

		protected virtual void Import(ImportContext context, JsonReader reader)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			ArrayList arrayList = new ArrayList();
			reader.ReadToken(JsonTokenClass.Array);
			while (reader.TokenClass != JsonTokenClass.EndArray)
			{
				arrayList.Add(context.Import(reader));
			}
			reader.Read();
			base.InnerList.Clear();
			base.InnerList.AddRange(arrayList);
		}

		public virtual object[] ToArray()
		{
			return (object[])ToArray(typeof(object));
		}

		public virtual Array ToArray(Type elementType)
		{
			return base.InnerList.ToArray(elementType);
		}

		public virtual void Reverse()
		{
			base.InnerList.Reverse();
		}

		public virtual int Push(object value)
		{
			Add(value);
			return base.Count;
		}

		public virtual int Push(params object[] values)
		{
			if (values != null)
			{
				foreach (object value in values)
				{
					Push(value);
				}
			}
			return base.Count;
		}

		public virtual object Pop()
		{
			if (base.Count == 0)
			{
				return null;
			}
			object result = base.InnerList[base.Count - 1];
			RemoveAt(base.Count - 1);
			return result;
		}

		public virtual JsonArray Concat(params object[] values)
		{
			JsonArray jsonArray = new JsonArray(this);
			if (values != null)
			{
				foreach (object obj in values)
				{
					JsonArray jsonArray2 = obj as JsonArray;
					if (jsonArray2 != null)
					{
						foreach (object item in jsonArray2)
						{
							jsonArray.Push(item);
						}
					}
					else
					{
						jsonArray.Push(obj);
					}
				}
			}
			return jsonArray;
		}

		public virtual object Shift()
		{
			if (base.Count == 0)
			{
				return null;
			}
			object result = base.InnerList[0];
			RemoveAt(0);
			return result;
		}

		public virtual JsonArray Unshift(object value)
		{
			base.InnerList.Insert(0, value);
			return this;
		}

		public virtual JsonArray Unshift(params object[] values)
		{
			if (values != null)
			{
				foreach (object value in values)
				{
					Unshift(value);
				}
			}
			return this;
		}
	}
}
