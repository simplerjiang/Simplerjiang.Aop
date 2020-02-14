#define DEBUG
using System;
using System.Diagnostics;
using System.Text;

namespace Jayrock.Diagnostics
{
	public sealed class DebugString
	{
		public static readonly string Ellipsis = "…";

		public static readonly char ControlReplacement = '?';

		public static string Format(string s)
		{
			return Format(s, 50);
		}

		public static string Format(string s, int width)
		{
			Debug.Assert(width > Ellipsis.Length);
			if (s == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(width);
			for (int i = 0; i < Math.Min(width, s.Length); i++)
			{
				stringBuilder.Append((!char.IsControl(s, i)) ? s[i] : ControlReplacement);
			}
			if (s.Length > width)
			{
				stringBuilder.Remove(width - Ellipsis.Length, Ellipsis.Length);
				stringBuilder.Append(Ellipsis);
			}
			return stringBuilder.ToString();
		}

		private DebugString()
		{
			throw new NotSupportedException();
		}
	}
}
