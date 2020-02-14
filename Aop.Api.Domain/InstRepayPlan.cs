using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InstRepayPlan : AopObject
	{
		[XmlElement("cur_term")]
		public bool CurTerm
		{
			get;
			set;
		}

		[XmlElement("cur_term_interest")]
		public string CurTermInterest
		{
			get;
			set;
		}

		[XmlElement("cur_term_interest_penalty")]
		public string CurTermInterestPenalty
		{
			get;
			set;
		}

		[XmlElement("cur_term_principal")]
		public string CurTermPrincipal
		{
			get;
			set;
		}

		[XmlElement("cur_term_principal_penalty")]
		public string CurTermPrincipalPenalty
		{
			get;
			set;
		}

		[XmlElement("repaid_interest")]
		public string RepaidInterest
		{
			get;
			set;
		}

		[XmlElement("repaid_interest_penalty")]
		public string RepaidInterestPenalty
		{
			get;
			set;
		}

		[XmlElement("repaid_principal")]
		public string RepaidPrincipal
		{
			get;
			set;
		}

		[XmlElement("repaid_principal_penalty")]
		public string RepaidPrincipalPenalty
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
	}
}
