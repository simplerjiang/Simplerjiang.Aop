using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ISVLogSync : AopObject
	{
		[XmlElement("application")]
		public string Application
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("exception_stack_trace")]
		public string ExceptionStackTrace
		{
			get;
			set;
		}

		[XmlElement("execution_millis")]
		public string ExecutionMillis
		{
			get;
			set;
		}

		[XmlElement("interface_name")]
		public string InterfaceName
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}

		[XmlElement("sync_type")]
		public string SyncType
		{
			get;
			set;
		}

		[XmlElement("timestamp")]
		public string Timestamp
		{
			get;
			set;
		}
	}
}
