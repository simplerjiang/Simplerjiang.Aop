using System;

namespace Jayrock.Json.Conversion
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class JsonIgnoreAttribute : Attribute
	{
	}
}
