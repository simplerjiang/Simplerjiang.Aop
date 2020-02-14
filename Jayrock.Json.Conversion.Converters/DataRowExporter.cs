#define DEBUG
using System;
using System.Data;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class DataRowExporter : ExporterBase
	{
		public DataRowExporter()
			: this(typeof(DataRow))
		{
		}

		public DataRowExporter(Type inputType)
			: base(inputType)
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(value != null);
			Debug.Assert(writer != null);
			ExportRow(context, (DataRow)value, writer);
		}

		internal static void ExportRow(ExportContext context, DataRow row, JsonWriter writer)
		{
			Debug.Assert(context != null);
			Debug.Assert(row != null);
			Debug.Assert(writer != null);
			writer.WriteStartObject();
			foreach (DataColumn column in row.Table.Columns)
			{
				writer.WriteMember(column.ColumnName);
				context.Export(row[column], writer);
			}
			writer.WriteEndObject();
		}
	}
}
