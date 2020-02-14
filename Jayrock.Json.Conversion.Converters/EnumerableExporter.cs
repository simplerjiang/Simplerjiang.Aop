#define DEBUG
using System;
using System.Collections;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class EnumerableExporter : ExporterBase
	{
		public EnumerableExporter(Type inputType)
			: base(inputType)
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			IEnumerable enumerable = (IEnumerable)value;
			writer.WriteStartArray();
			foreach (object item in enumerable)
			{
				context.Export(item, writer);
			}
			writer.WriteEndArray();
		}
	}
}
