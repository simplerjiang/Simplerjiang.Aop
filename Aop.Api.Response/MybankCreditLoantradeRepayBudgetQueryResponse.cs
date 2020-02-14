using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeRepayBudgetQueryResponse : AopResponse
	{
		[XmlElement("apply_repay_prin")]
		public string ApplyRepayPrin
		{
			get;
			set;
		}

		[XmlElement("loan_ar_no")]
		public string LoanArNo
		{
			get;
			set;
		}

		[XmlElement("should_repay_fee")]
		public string ShouldRepayFee
		{
			get;
			set;
		}

		[XmlElement("should_repay_int")]
		public string ShouldRepayInt
		{
			get;
			set;
		}

		[XmlElement("should_repay_pre_fee")]
		public string ShouldRepayPreFee
		{
			get;
			set;
		}

		[XmlElement("should_repay_prin")]
		public string ShouldRepayPrin
		{
			get;
			set;
		}
	}
}
