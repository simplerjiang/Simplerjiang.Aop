using System;

namespace Jayrock.Json.Conversion.Converters
{
	public abstract class NumberExporterBase : ExporterBase
	{
		protected NumberExporterBase(Type inputType)
			: base(inputType)
		{
		}

		protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			string value2;
			try
			{
				value2 = ConvertToString(value);
			}
			catch (InvalidCastException ex)
			{
				throw new JsonException(ex.Message, ex);
			}
			writer.WriteNumber(value2);
		}

		protected abstract string ConvertToString(object value);
	}
}
