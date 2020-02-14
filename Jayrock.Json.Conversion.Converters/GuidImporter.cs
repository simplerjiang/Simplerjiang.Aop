#define DEBUG
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class GuidImporter : ImporterBase
	{
		public GuidImporter()
			: base(typeof(Guid))
		{
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			try
			{
				return ImporterBase.ReadReturning(reader, new Guid(reader.Text.Trim()));
			}
			catch (FormatException ex)
			{
				throw new JsonException(ex.Message, ex);
			}
		}
	}
}
