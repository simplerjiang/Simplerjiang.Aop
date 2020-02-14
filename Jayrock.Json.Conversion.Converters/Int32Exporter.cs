using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class Int32Exporter : NumberExporterBase
	{
		public Int32Exporter()
			: base(typeof(int))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((int)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
