using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodLoanApplyResponse : AopResponse
	{
		[XmlElement("app_seqno")]
		public string AppSeqno
		{
			get;
			set;
		}

		[XmlElement("need_auth")]
		public string NeedAuth
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
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
