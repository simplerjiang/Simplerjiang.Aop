using System;
using System.Runtime.Serialization;

namespace Jayrock.Json
{
	[Serializable]
	public class JsonException : ApplicationException
	{
		private const string _defaultMessage = "An error occurred dealing with JSON data.";

		public JsonException()
			: this(null)
		{
		}

		public JsonException(string message)
			: base(Mask.NullString(message, "An error occurred dealing with JSON data."), null)
		{
		}

		public JsonException(string message, Exception innerException)
			: base(Mask.NullString(message, "An error occurred dealing with JSON data."), innerException)
		{
		}

		protected JsonException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
