using System;

namespace Jayrock
{
	internal sealed class BooleanObject
	{
		public static readonly object True = true;

		public static readonly object False = false;

		public static object Box(bool value)
		{
			return value ? True : False;
		}

		private BooleanObject()
		{
			throw new NotSupportedException();
		}
	}
}
