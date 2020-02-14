using Jayrock.Json.Conversion;
using System;
using System.Runtime.Serialization;

namespace Jayrock.Json
{
	[Serializable]
	public sealed class JsonNull : IObjectReference, IJsonExportable
	{
		public const string Text = "null";

		public static readonly JsonNull Value = new JsonNull();

		private JsonNull()
		{
		}

		public override string ToString()
		{
			return "null";
		}

		public static bool LogicallyEquals(object o)
		{
			if (o == null)
			{
				return true;
			}
			if (o.Equals(Value))
			{
				return true;
			}
			if (Convert.IsDBNull(o))
			{
				return true;
			}
			return false;
		}

		void IJsonExportable.Export(ExportContext context, JsonWriter writer)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteNull();
		}

		object IObjectReference.GetRealObject(StreamingContext context)
		{
			return Value;
		}
	}
}
