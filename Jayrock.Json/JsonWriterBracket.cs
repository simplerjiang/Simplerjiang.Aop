using System;

namespace Jayrock.Json
{
	[Serializable]
	public enum JsonWriterBracket
	{
		Pending,
		Array,
		Object,
		Member,
		Closed
	}
}
