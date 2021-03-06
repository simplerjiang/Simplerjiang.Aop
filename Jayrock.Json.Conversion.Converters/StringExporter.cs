#define DEBUG
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class StringExporter : ExporterBase
	{
		public StringExporter()
			: this(typeof(string))
		{
		}

		public StringExporter(Type type)
			: base(type)
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			writer.WriteString(value.ToString());
		}
	}
}
