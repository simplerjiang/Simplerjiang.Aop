using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LoanScheme : AopObject
	{
		[XmlElement("credit_expire_date")]
		public string CreditExpireDate
		{
			get;
			set;
		}

		[XmlElement("credit_lmt_amt")]
		public string CreditLmtAmt
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

		[XmlElement("credit_source")]
		public string CreditSource
		{
			get;
			set;
		}

		[XmlElement("credit_start_date")]
		public string CreditStartDate
		{
			get;
			set;
		}

		[XmlElement("int_rate")]
		public string IntRate
		{
			get;
			set;
		}

		[XmlElement("loan_policy_code")]
		public string LoanPolicyCode
		{
			get;
			set;
		}

		[XmlElement("loan_term")]
		public long LoanTerm
		{
			get;
			set;
		}

		[XmlElement("loan_term_unit")]
		public string LoanTermUnit
		{
			get;
			set;
		}

		[XmlElement("loanable_amt")]
		public string LoanableAmt
		{
			get;
			set;
		}

		[XmlElement("repay_day")]
		public long RepayDay
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

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("sale_pd_version")]
		public string SalePdVersion
		{
			get;
			set;
		}
	}
}
