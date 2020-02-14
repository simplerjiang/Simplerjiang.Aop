using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradePartnerPaymentApplyResponse : AopResponse
	{
		[XmlElement("in_apply_no")]
		public string InApplyNo
		{
			get;
			set;
		}
	}
}
