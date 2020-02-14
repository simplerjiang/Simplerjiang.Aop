using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InstallmentRepayPlan : AopObject
	{
		[XmlElement("cur_term")]
		public bool CurTerm
		{
			get;
			set;
		}

		[XmlElement("paid_int_bal")]
		public string PaidIntBal
		{
			get;
			set;
		}

		[XmlElement("paid_prin_bal")]
		public string PaidPrinBal
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

		[XmlElement("term_nom_int")]
		public string TermNomInt
		{
			get;
			set;
		}

		[XmlElement("term_nom_prin")]
		public string TermNomPrin
		{
			get;
			set;
		}

		[XmlElement("term_ovd_int")]
		public string TermOvdInt
		{
			get;
			set;
		}

		[XmlElement("term_ovd_int_pen_int")]
		public string TermOvdIntPenInt
		{
			get;
			set;
		}

		[XmlElement("term_ovd_prin")]
		public string TermOvdPrin
		{
			get;
			set;
		}

		[XmlElement("term_ovd_prin_pen_int")]
		public string TermOvdPrinPenInt
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
