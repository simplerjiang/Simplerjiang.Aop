using System;

namespace Jayrock.Json.Conversion.Converters
{
	public abstract class NumberImporterBase : ImporterBase
	{
		protected NumberImporterBase(Type type)
			: base(type)
		{
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			return ImportFromNumber(context, reader);
		}

		protected override object ImportFromNumber(ImportContext context, JsonReader reader)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			string text = reader.Text;
			try
			{
				return ImporterBase.ReadReturning(reader, ConvertFromString(text));
			}
			catch (FormatException e)
			{
				throw NumberError(e, text);
			}
			catch (OverflowException e2)
			{
				throw NumberError(e2, text);
			}
		}

		protected override object ImportFromBoolean(ImportContext context, JsonReader reader)
		{
			return Convert.ChangeType(BooleanObject.Box(reader.ReadBoolean()), base.OutputType);
		}

		protected abstract object ConvertFromString(string s);

		private Exception NumberError(Exception e, string text)
		{
			return new JsonException($"Error importing JSON Number {text} as {base.OutputType.FullName}.", e);
		}
	}
}
