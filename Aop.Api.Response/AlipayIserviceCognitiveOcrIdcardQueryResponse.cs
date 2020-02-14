using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrIdcardQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("birth")]
		public string Birth
		{
			get;
			set;
		}

		[XmlElement("error_content")]
		public string ErrorContent
		{
			get;
			set;
		}

		[XmlElement("nationality")]
		public string Nationality
		{
			get;
			set;
		}

		[XmlElement("num")]
		public string Num
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

		[XmlElement("sex")]
		public string Sex
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
