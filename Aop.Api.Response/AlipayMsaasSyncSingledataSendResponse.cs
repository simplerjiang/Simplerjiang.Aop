using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMsaasSyncSingledataSendResponse : AopResponse
	{
		[XmlElement("oplog_id")]
		public string OplogId
		{
			get;
			set;
		}

		[XmlElement("return_code")]
		public string ReturnCode
		{
			get;
			set;
		}

		[XmlElement("return_reason")]
		public string ReturnReason
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
