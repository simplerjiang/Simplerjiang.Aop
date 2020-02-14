#define DEBUG
using Jayrock.Diagnostics;
using System;
using System.Diagnostics;

namespace Jayrock.Json.Conversion.Converters
{
	public sealed class EnumImporter : ImporterBase
	{
		public EnumImporter(Type type)
			: base(type)
		{
			if (!type.IsEnum)
			{
				throw new ArgumentException($"{type} does not inherit from System.Enum.");
			}
			if (type.IsDefined(typeof(FlagsAttribute), inherit: true))
			{
				throw new ArgumentException($"{type} is a bit field, which are not currently supported.");
			}
		}

		protected override object ImportFromString(ImportContext context, JsonReader reader)
		{
			Debug.Assert(context != null);
			Debug.Assert(reader != null);
			string text = reader.Text.Trim();
			if (text.Length > 0)
			{
				char c = text[0];
				if (char.IsDigit(c) || c == '+' || c == '-')
				{
					throw Error(text, null);
				}
			}
			try
			{
				return ImporterBase.ReadReturning(reader, Enum.Parse(base.OutputType, text, ignoreCase: true));
			}
			catch (ArgumentException e)
			{
				throw Error(text, e);
			}
		}

		private JsonException Error(string s, Exception e)
		{
			return new JsonException($"The value '{DebugString.Format(s)}' cannot be imported as {base.OutputType.FullName}.", e);
		}
	}
}
