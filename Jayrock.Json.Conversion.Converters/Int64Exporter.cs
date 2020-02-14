using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class Int64Exporter : NumberExporterBase
	{
		public Int64Exporter()
			: base(typeof(long))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((long)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
