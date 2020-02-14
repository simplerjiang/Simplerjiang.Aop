using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class DecimalExporter : NumberExporterBase
	{
		public DecimalExporter()
			: base(typeof(decimal))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((decimal)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
