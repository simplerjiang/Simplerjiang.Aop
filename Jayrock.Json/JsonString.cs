#define DEBUG
using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Jayrock.Json
{
	public sealed class JsonString
	{
		public static string Enquote(string s)
		{
			if (s == null || s.Length == 0)
			{
				return "\"\"";
			}
			return Enquote(s, null).ToString();
		}

		public static StringBuilder Enquote(string s, StringBuilder sb)
		{
			int length = Mask.NullString(s).Length;
			if (sb == null)
			{
				sb = new StringBuilder(length + 4);
			}
			sb.Append('"');
			char c = '\0';
			for (int i = 0; i < length; i++)
			{
				char c2 = c;
				c = s[i];
				switch (c)
				{
				case '"':
				case '\\':
					sb.Append('\\');
					sb.Append(c);
					continue;
				case '/':
					if (c2 == '<')
					{
						sb.Append('\\');
					}
					sb.Append(c);
					continue;
				case '\b':
					sb.Append("\\b");
					continue;
				case '\t':
					sb.Append("\\t");
					continue;
				case '\n':
					sb.Append("\\n");
					continue;
				case '\f':
					sb.Append("\\f");
					continue;
				case '\r':
					sb.Append("\\r");
					continue;
				}
				if (c < ' ')
				{
					sb.Append("\\u");
					StringBuilder stringBuilder = sb;
					int num = c;
					stringBuilder.Append(num.ToString("x4", CultureInfo.InvariantCulture));
				}
				else
				{
					sb.Append(c);
				}
			}
			return sb.Append('"');
		}

		internal static string Dequote(BufferedCharReader input, char quote)
		{
			return Dequote(input, quote, null).ToString();
		}

		internal static StringBuilder Dequote(BufferedCharReader input, char quote, StringBuilder output)
		{
			Debug.Assert(input != null);
			if (output == null)
			{
				output = new StringBuilder();
			}
			char[] array = null;
			while (true)
			{
				char c = input.Next();
				switch (c)
				{
				case '\0':
					throw new FormatException("Unterminated string.");
				case '\\':
					c = input.Next();
					switch (c)
					{
					case 'b':
						output.Append('\b');
						break;
					case 't':
						output.Append('\t');
						break;
					case 'n':
						output.Append('\n');
						break;
					case 'f':
						output.Append('\f');
						break;
					case 'r':
						output.Append('\r');
						break;
					case 'u':
						if (array == null)
						{
							array = new char[4];
						}
						output.Append(ParseHex(input, array));
						break;
					default:
						output.Append(c);
						break;
					}
					break;
				default:
					if (c == quote)
					{
						return output;
					}
					output.Append(c);
					break;
				}
			}
		}

		private static char ParseHex(BufferedCharReader input, char[] hexDigits)
		{
			Debug.Assert(input != null);
			Debug.Assert(hexDigits != null);
			Debug.Assert(hexDigits.Length == 4);
			hexDigits[0] = input.Next();
			hexDigits[1] = input.Next();
			hexDigits[2] = input.Next();
			hexDigits[3] = input.Next();
			return (char)ushort.Parse(new string(hexDigits), NumberStyles.HexNumber);
		}

		private JsonString()
		{
			throw new NotSupportedException();
		}
	}
}
