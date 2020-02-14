using System;
using System.Collections.Specialized;

namespace Jayrock.Json.Conversion.Converters
{
	public class NameValueCollectionImporter : ImporterBase
	{
		public NameValueCollectionImporter()
			: base(typeof(NameValueCollection))
		{
		}

		protected override object ImportFromObject(ImportContext context, JsonReader reader)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.TokenClass != JsonTokenClass.Object)
			{
				throw new JsonException("Expecting object.");
			}
			reader.Read();
			NameValueCollection nameValueCollection = CreateCollection();
			while (reader.TokenClass != JsonTokenClass.EndObject)
			{
				string name = reader.ReadMember();
				if (reader.TokenClass == JsonTokenClass.Array)
				{
					reader.Read();
					while (reader.TokenClass != JsonTokenClass.EndArray)
					{
						nameValueCollection.Add(name, GetValueAsString(reader));
						reader.Read();
					}
				}
				else
				{
					nameValueCollection.Add(name, GetValueAsString(reader));
				}
				reader.Read();
			}
			return nameValueCollection;
		}

		protected virtual string GetValueAsString(JsonReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.TokenClass == JsonTokenClass.String || reader.TokenClass == JsonTokenClass.Boolean || reader.TokenClass == JsonTokenClass.Number)
			{
				return reader.Text;
			}
			if (reader.TokenClass == JsonTokenClass.Null)
			{
				return null;
			}
			throw new JsonException($"Cannot put a JSON {reader.TokenClass} value in a NameValueCollection instance.");
		}

		protected virtual NameValueCollection CreateCollection()
		{
			return new NameValueCollection();
		}
	}
}
