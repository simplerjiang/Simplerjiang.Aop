using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeRepayInitiativeApplyModel : AopObject
	{
		[XmlElement("loan_ar_no")]
		public string LoanArNo
		{
			get;
			set;
		}

		[XmlElement("repay_account")]
		public Account RepayAccount
		{
			get;
			set;
		}

		[XmlElement("repay_amount")]
		public string RepayAmount
		{
			get;
			set;
		}

		[XmlElement("repay_amount_strategy")]
		public string RepayAmountStrategy
		{
			get;
			set;
		}

		[XmlElement("repay_customer")]
		public Member RepayCustomer
		{
			get;
			set;
		}

		[XmlElement("repay_date")]
		public string RepayDate
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

		[XmlElement("trans_memo")]
		public string TransMemo
		{
			get;
			set;
		}
	}
}
