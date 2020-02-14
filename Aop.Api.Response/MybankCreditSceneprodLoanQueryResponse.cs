using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodLoanQueryResponse : AopResponse
	{
		[XmlElement("desc_msg")]
		public string DescMsg
		{
			get;
			set;
		}

		[XmlElement("info")]
		public string Info
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public string Retry
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
