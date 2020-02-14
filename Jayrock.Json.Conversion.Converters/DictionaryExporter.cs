#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class DictionaryExporter : ExporterBase
	{
		public DictionaryExporter(Type inputType)
			: base(inputType)
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			writer.WriteStartObject();
			IDictionary dictionary = (IDictionary)value;
			foreach (DictionaryEntry item in dictionary)
			{
				writer.WriteMember(item.Key.ToString());
				context.Export(item.Value, writer);
			}
			writer.WriteEndObject();
		}
	}
}
