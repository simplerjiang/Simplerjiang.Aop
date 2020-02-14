using System;
using System.Globalization;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class SingleImporter : NumberImporterBase
	{
		public SingleImporter()
			: base(typeof(float))
		{
		}

		protected override object ConvertFromString(string s)
		{
			return Convert.ToSingle(s, CultureInfo.InvariantCulture);
		}
	}
}
