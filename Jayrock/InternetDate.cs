using System;
using System.Globalization;

namespace Jayrock
{
	public sealed class InternetDate
	{
		private static readonly string[] _formats = new string[4]
		{
			"dd MMM yyyy HH':'mm",
			"dd MMM yyyy HH':'mm':'ss",
			"ddd, dd MMM yyyy HH':'mm",
			"ddd, dd MMM yyyy HH':'mm':'ss"
		};

		public static DateTime Parse(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (input.Length < _formats[0].Length)
			{
				throw new ArgumentException("input");
			}
			int num = input.LastIndexOf(' ');
			if (num <= 0)
			{
				throw new FormatException();
			}
			string text = input.Substring(num + 1);
			if (text.Length == 0)
			{
				throw new FormatException("Missing time zone.");
			}
			int num2;
			switch (text)
			{
			case "UT":
			case "GMT":
				num2 = 0;
				break;
			case "EDT":
				num2 = -400;
				break;
			case "EST":
			case "CDT":
				num2 = -500;
				break;
			case "CST":
			case "MDT":
				num2 = -600;
				break;
			case "MST":
			case "PDT":
				num2 = -700;
				break;
			case "PST":
				num2 = -800;
				break;
			default:
				if (text.Length < 4)
				{
					throw new FormatException("Length of local differential component must be at least 4 characters (HHMM).");
				}
				try
				{
					num2 = int.Parse(text, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);
				}
				catch (FormatException innerException)
				{
					throw new FormatException("Invalid local differential.", innerException);
				}
				break;
			}
			input = input.Substring(0, num).TrimEnd();
			DateTime dateTime = DateTime.ParseExact(input, _formats, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite);
			TimeSpan value = new TimeSpan(num2 / 100, num2 % 100, 0);
			return dateTime.Subtract(value).ToLocalTime();
		}

		private InternetDate()
		{
			throw new NotSupportedException();
		}
	}
}
