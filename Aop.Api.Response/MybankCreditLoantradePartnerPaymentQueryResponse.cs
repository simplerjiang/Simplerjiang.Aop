using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradePartnerPaymentQueryResponse : AopResponse
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
