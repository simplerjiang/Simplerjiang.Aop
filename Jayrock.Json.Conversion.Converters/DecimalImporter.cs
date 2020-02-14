using System;
using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class DecimalImporter : NumberImporterBase
	{
		public DecimalImporter()
			: base(typeof(decimal))
		{
		}

		protected override object ConvertFromString(string s)
		{
			return Convert.ToDecimal(s, CultureInfo.InvariantCulture);
		}
	}
}
