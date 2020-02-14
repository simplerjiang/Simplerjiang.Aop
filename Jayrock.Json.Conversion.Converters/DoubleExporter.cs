using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class DoubleExporter : NumberExporterBase
	{
		public DoubleExporter()
			: base(typeof(double))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((double)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
