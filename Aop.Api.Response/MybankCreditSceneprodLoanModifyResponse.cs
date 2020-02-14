using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodLoanModifyResponse : AopResponse
	{
		[XmlElement("result_content")]
		public string ResultContent
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
