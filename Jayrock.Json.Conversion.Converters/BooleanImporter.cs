#define DEBUG
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class BooleanImporter : ImporterBase
	{
		public BooleanImporter()
			: base(typeof(bool))
		{
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			return BooleanObject.Box(reader.ReadBoolean());
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			try
			{
				return BooleanObject.Box(reader.ReadNumber().ToInt64() != 0);
			}
			catch (FormatException innerException)
			{
				throw new JsonException($"The JSON Number {reader.Text} must be an integer to be convertible to System.Boolean.", innerException);
			}
		}
	}
}
