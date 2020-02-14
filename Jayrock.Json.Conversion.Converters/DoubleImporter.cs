using System;
using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class DoubleImporter : NumberImporterBase
	{
		public DoubleImporter()
			: base(typeof(double))
		{
		}

		protected override object ConvertFromString(string s)
		{
			return Convert.ToDouble(s, CultureInfo.InvariantCulture);
		}
	}
}
