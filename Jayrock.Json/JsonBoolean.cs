using System;

namespace Jayrock.Json
{
	public sealed class JsonBoolean
	{
		public const string TrueText = "true";

		public const string FalseText = "false";

		private JsonBoolean()
		{
			throw new NotSupportedException();
		}
	}
}
