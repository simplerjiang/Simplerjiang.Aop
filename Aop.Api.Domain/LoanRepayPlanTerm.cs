using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LoanRepayPlanTerm : AopObject
	{
		[XmlElement("current_term")]
		public bool CurrentTerm
		{
			get;
			set;
		}

		[XmlElement("paid_amt")]
		public LoanMoneyTypeAmt PaidAmt
		{
			get;
			set;
		}

		[XmlElement("remain_amt")]
		public LoanMoneyTypeAmt RemainAmt
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

		[XmlElement("term_end_date")]
		public string TermEndDate
		{
			get;
			set;
		}

		[XmlElement("term_no")]
		public long TermNo
		{
			get;
			set;
		}

		[XmlElement("term_start_date")]
		public string TermStartDate
		{
			get;
			set;
		}

		[XmlElement("total_amt")]
		public LoanMoneyTypeAmt TotalAmt
		{
			get;
			set;
		}
	}
}
