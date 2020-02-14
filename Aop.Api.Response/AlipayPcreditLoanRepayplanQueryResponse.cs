using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditLoanRepayplanQueryResponse : AopResponse
	{
		[XmlElement("ar_no")]
		public string ArNo
		{
			get;
			set;
		}

		[XmlElement("current_term")]
		public long CurrentTerm
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

		[XmlElement("loan_apply_no")]
		public string LoanApplyNo
		{
			get;
			set;
		}

		[XmlElement("loan_date")]
		public string LoanDate
		{
			get;
			set;
		}

		[XmlElement("ovd_date")]
		public string OvdDate
		{
			get;
			set;
		}

		[XmlElement("remain_repay_amt")]
		public LoanMoneyTypeAmt RemainRepayAmt
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

		[XmlArray("repay_plan_term_list")]
		[XmlArrayItem("loan_repay_plan_term")]
		public List<LoanRepayPlanTerm> RepayPlanTermList
		{
			get;
			set;
		}

		[XmlElement("settle_date")]
		public string SettleDate
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

		[XmlElement("term_unit")]
		public string TermUnit
		{
			get;
			set;
		}

		[XmlElement("terms")]
		public long Terms
		{
			get;
			set;
		}
	}
}
