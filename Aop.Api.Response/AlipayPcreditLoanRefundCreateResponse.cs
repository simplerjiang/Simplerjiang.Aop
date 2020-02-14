using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditLoanRefundCreateResponse : AopResponse
	{
		[XmlElement("loan_repay_no")]
		public string LoanRepayNo
		{
			get;
			set;
		}
	}
}
