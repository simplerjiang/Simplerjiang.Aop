using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodPaymentApplyResponse : AopResponse
	{
		[XmlElement("in_apply_no")]
		public string InApplyNo
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
