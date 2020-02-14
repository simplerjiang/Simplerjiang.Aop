using System;
using System.Runtime.Serialization;

namespace Aop.Api
{
	public class AopException : Exception
	{
		private string errorCode;

		private string errorMsg;

		public string ErrorCode => errorCode;

		public string ErrorMsg => errorMsg;

		public AopException()
		{
		}

		public AopException(string message)
			: base(message)
		{
		}

		protected AopException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public AopException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public AopException(string errorCode, string errorMsg)
			: base(errorCode + ":" + errorMsg)
		{
			this.errorCode = errorCode;
			this.errorMsg = errorMsg;
		}
	}
}
