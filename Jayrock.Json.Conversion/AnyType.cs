using System;

namespace Jayrock.Json.Conversion
{
	public sealed class AnyType
	{
		public static readonly Type Value = typeof(object);

		private AnyType()
		{
			throw new NotImplementedException();
		}
	}
}
