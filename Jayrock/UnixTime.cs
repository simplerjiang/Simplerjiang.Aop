using System;

namespace Jayrock
{
	public sealed class UnixTime
	{
		private static readonly int[] _days = new int[13]
		{
			-1,
			30,
			58,
			89,
			119,
			150,
			180,
			211,
			242,
			272,
			303,
			333,
			364
		};

		private static readonly int[] _leapDays = new int[13]
		{
			-1,
			30,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		public static DateTime ToDateTime(long time)
		{
			int num = (int)(time / 31536000) + 70;
			time -= (long)(num - 70) * 31536000L;
			time -= ElapsedLeapYears(num) * 86400;
			bool flag = false;
			if (time < 0)
			{
				time += 31536000;
				num--;
				if (IsLeapYear(num))
				{
					time += 86400;
					flag = true;
				}
			}
			else if (IsLeapYear(num))
			{
				flag = true;
			}
			int num2 = num;
			int num3 = (int)(time / 86400);
			time -= (long)num3 * 86400L;
			int[] array = flag ? _leapDays : _days;
			int i;
			for (i = 1; array[i] < num3; i++)
			{
			}
			int day = num3 - array[i - 1];
			int num4 = (int)(time / 3600);
			time -= (long)num4 * 3600L;
			int num5 = (int)(time / 60);
			int second = (int)(time - num5 * 60);
			return new DateTime(num2 + 1900, i, day, num4, num5, second).ToLocalTime();
		}

		public static long ToInt64(DateTime time)
		{
			return (long)(time.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
		}

		private static bool IsLeapYear(int y)
		{
			return (y % 4 == 0 && y % 100 != 0) || (y + 1900) % 400 == 0;
		}

		private static long ElapsedLeapYears(int y)
		{
			return (y - 1) / 4 - (y - 1) / 100 + (y + 299) / 400 - 17;
		}

		private UnixTime()
		{
			throw new NotSupportedException();
		}
	}
}
