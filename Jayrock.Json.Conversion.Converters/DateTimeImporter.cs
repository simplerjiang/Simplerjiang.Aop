#define DEBUG
using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class DateTimeImporter : ImporterBase
	{
		public DateTimeImporter()
			: base(typeof(DateTime))
		{
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			try
			{
				return ImporterBase.ReadReturning(reader, XmlConvert.ToDateTime(reader.Text, XmlDateTimeSerializationMode.Local));
			}
			catch (FormatException innerException)
			{
				throw new JsonException("Error importing JSON String as System.DateTime.", innerException);
			}
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			string text = reader.Text;
			long time;
			try
			{
				time = Convert.ToInt64(text, CultureInfo.InvariantCulture);
			}
			catch (FormatException e)
			{
				throw NumberError(e, text);
			}
			catch (OverflowException e2)
			{
				throw NumberError(e2, text);
			}
			try
			{
				return ImporterBase.ReadReturning(reader, UnixTime.ToDateTime(time));
			}
			catch (ArgumentException e3)
			{
				throw NumberError(e3, text);
			}
		}

		private static JsonException NumberError(Exception e, string text)
		{
			return new JsonException($"Error importing JSON Number {text} as System.DateTime.", e);
		}

		protected override JsonException GetImportException(string jsonValueType)
		{
			return new JsonException($"Found {jsonValueType} where expecting a JSON String in ISO 8601 time format or a JSON Number expressed in Unix time.");
		}
	}
}
