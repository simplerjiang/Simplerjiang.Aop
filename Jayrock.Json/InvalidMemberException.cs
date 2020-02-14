using System;
using System.Runtime.Serialization;

namespace Jayrock.Json
{
	[Serializable]
	public class InvalidMemberException : ApplicationException
	{
		private const string _defaultMessage = "No element exists at the specified index.";

		public InvalidMemberException()
			: this(null)
		{
		}

		public InvalidMemberException(string message)
			: base(Mask.NullString(message, "No element exists at the specified index."))
		{
		}

		public InvalidMemberException(string message, Exception innerException)
			: base(Mask.NullString(message, "No element exists at the specified index."), innerException)
		{
		}

		protected InvalidMemberException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
