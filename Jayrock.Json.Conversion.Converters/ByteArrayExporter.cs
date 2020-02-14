#define DEBUG
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class ByteArrayExporter : ExporterBase
	{
		public ByteArrayExporter()
			: base(typeof(byte[]))
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			byte[] inArray = (byte[])value;
			writer.WriteString(Convert.ToBase64String(inArray));
		}
	}
}
