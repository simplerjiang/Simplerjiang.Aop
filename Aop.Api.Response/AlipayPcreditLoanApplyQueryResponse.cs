using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditLoanApplyQueryResponse : AopResponse
	{
		[XmlElement("apply_amt")]
		public string ApplyAmt
		{
			get;
			set;
		}

		[XmlElement("apply_date")]
		public string ApplyDate
		{
			get;
			set;
		}

		[XmlElement("ar_no")]
		public string ArNo
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("credit_no")]
		public string CreditNo
		{
			get;
			set;
		}

		[XmlElement("daily_int_rate")]
		public string DailyIntRate
		{
			get;
			set;
		}

		[XmlElement("due_date")]
		public string DueDate
		{
			get;
			set;
		}

		[XmlElement("encash_org")]
		public string EncashOrg
		{
			get;
			set;
		}

		[XmlElement("loan_apply_no")]
		public string LoanApplyNo
		{
			get;
			set;
		}

		[XmlElement("need_prepayment_fee")]
		public bool NeedPrepaymentFee
		{
			get;
			set;
		}

		[XmlElement("payment_dt")]
		public string PaymentDt
		{
			get;
			set;
		}

		[XmlElement("repay_mode")]
		public string RepayMode
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

		[XmlElement("term")]
		public long Term
		{
			get;
			set;
		}

		[XmlElement("term_unit")]
		public string TermUnit
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
