using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrBankcardQueryResponse : AopResponse
	{
		[XmlElement("card_num")]
		public string CardNum
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
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

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}
	}
}
