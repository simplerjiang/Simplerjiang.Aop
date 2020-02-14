using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CreditResult : AopObject
	{
		[XmlElement("credit_line")]
		public string CreditLine
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

		[XmlElement("credit_term")]
		public long CreditTerm
		{
			get;
			set;
		}

		[XmlElement("credit_term_unit")]
		public string CreditTermUnit
		{
			get;
			set;
		}

		[XmlElement("effective_date")]
		public string EffectiveDate
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("fee_rate")]
		public string FeeRate
		{
			get;
			set;
		}

		[XmlElement("interest_rate")]
		public string InterestRate
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

		[XmlElement("repayment_mode")]
		public string RepaymentMode
		{
			get;
			set;
		}
	}
}
