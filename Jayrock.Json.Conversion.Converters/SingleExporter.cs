using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public class SingleExporter : NumberExporterBase
	{
		public SingleExporter()
			: base(typeof(float))
		{
		}

		protected override string ConvertToString(object value)
		{
			return ((float)value).ToString(CultureInfo.InvariantCulture);
		}
	}
}
