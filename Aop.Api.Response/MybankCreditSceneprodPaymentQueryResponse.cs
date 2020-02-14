using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodPaymentQueryResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("finish_time")]
		public string FinishTime
		{
			get;
			set;
		}

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

		[XmlElement("status")]
		public string Status
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
