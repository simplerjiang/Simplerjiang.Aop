using Jayrock.Json.Conversion;
using System;
using System.Collections;

namespace Jayrock.Json
{
	[Serializable]
	public class JsonObject : DictionaryBase, IJsonImportable, IJsonExportable
	{
		private ArrayList _nameIndexList;

		[NonSerialized]
		private IList _readOnlyNameIndexList;

		public virtual object this[string key]
		{
			get
			{
				return base.InnerHashtable[key];
			}
			set
			{
				Put(key, value);
			}
		}

		public virtual bool HasMembers => base.Count > 0;

		private ArrayList NameIndexList
		{
			get
			{
				if (_nameIndexList == null)
				{
					_nameIndexList = new ArrayList();
				}
				return _nameIndexList;
			}
		}

		public virtual ICollection Names
		{
			get
			{
				if (_readOnlyNameIndexList == null)
				{
					_readOnlyNameIndexList = ArrayList.ReadOnly(NameIndexList);
				}
				return _readOnlyNameIndexList;
			}
		}

		public JsonObject()
		{
		}

		public JsonObject(IDictionary members)
		{
			foreach (DictionaryEntry member in members)
			{
				if (member.Key == null)
				{
					throw new InvalidMemberException();
				}
				base.InnerHashtable.Add(member.Key.ToString(), member.Value);
			}
			_nameIndexList = new ArrayList(members.Keys);
		}

		public JsonObject(string[] keys, object[] values)
		{
			int num = (keys != null) ? keys.Length : 0;
			int num2 = (values != null) ? values.Length : 0;
			int num3 = Math.Max(num, num2);
			string name = string.Empty;
			for (int i = 0; i < num3; i++)
			{
				if (i < num)
				{
					name = Mask.NullString(keys[i]);
				}
				Accumulate(name, (i < num2) ? values[i] : null);
			}
		}

		public virtual JsonObject Accumulate(string name, object value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			object obj = base.InnerHashtable[name];
			if (obj == null)
			{
				Put(name, value);
			}
			else
			{
				IList list = obj as IList;
				if (list != null)
				{
					list.Add(value);
				}
				else
				{
					list = new JsonArray();
					list.Add(obj);
					list.Add(value);
					Put(name, list);
				}
			}
			return this;
		}

		public virtual JsonObject Put(string name, object value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			base.Dictionary[name] = value;
			return this;
		}

		public virtual bool Contains(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return base.Dictionary.Contains(name);
		}

		public virtual void Remove(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			base.Dictionary.Remove(name);
		}

		public virtual JsonArray GetNamesArray()
		{
			JsonArray jsonArray = new JsonArray();
			ListNames(jsonArray);
			return jsonArray;
		}

		public virtual void ListNames(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			foreach (string nameIndex in NameIndexList)
			{
				list.Add(nameIndex);
			}
		}

		public override string ToString()
		{
			JsonTextWriter jsonTextWriter = new JsonTextWriter();
			Export(jsonTextWriter);
			return jsonTextWriter.ToString();
		}

		public void Export(JsonWriter writer)
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
			writer.WriteStartObject();
			foreach (string nameIndex in NameIndexList)
			{
				writer.WriteMember(nameIndex);
				context.Export(base.InnerHashtable[nameIndex], writer);
			}
			writer.WriteEndObject();
		}

		public void Import(JsonReader reader)
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
			Clear();
			reader.ReadToken(JsonTokenClass.Object);
			while (reader.TokenClass != JsonTokenClass.EndObject)
			{
				Put(reader.ReadMember(), context.Import(reader));
			}
			reader.Read();
		}

		protected override void OnValidate(object key, object value)
		{
			base.OnValidate(key, value);
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!(key is string))
			{
				throw new ArgumentException("key", $"The key cannot be of the supplied type {key.GetType().FullName}. It must be typed System.String.");
			}
		}

		protected override void OnInsert(object key, object value)
		{
			NameIndexList.Add(key);
		}

		protected override void OnSet(object key, object oldValue, object newValue)
		{
			if (oldValue == null && !NameIndexList.Contains(key))
			{
				OnInsert(key, newValue);
			}
		}

		protected override void OnRemove(object key, object value)
		{
			NameIndexList.Remove(key);
		}

		protected override void OnClear()
		{
			NameIndexList.Clear();
		}
	}
}
