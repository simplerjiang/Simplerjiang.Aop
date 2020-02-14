using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class Int16Exporter : NumberExporterBase
	{
		public Int16Exporter()
			: base(typeof(short))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((short)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
