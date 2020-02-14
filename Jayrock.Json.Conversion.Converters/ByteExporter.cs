using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class ByteExporter : NumberExporterBase
	{
		public ByteExporter()
			: base(typeof(byte))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((byte)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
