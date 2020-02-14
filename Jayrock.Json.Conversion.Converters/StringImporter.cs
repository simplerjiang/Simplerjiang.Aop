#define DEBUG
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class StringImporter : ImporterBase
	{
		public StringImporter()
			: base(typeof(string))
		{
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return ImportFromString(context, reader);
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			return ImportFromString(context, reader);
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			return ImporterBase.ReadReturning(reader, reader.Text);
		}
	}
}
