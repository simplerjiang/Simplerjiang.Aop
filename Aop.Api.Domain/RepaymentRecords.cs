using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RepaymentRecords : AopObject
	{
		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("interest")]
		public string Interest
		{
			get;
			set;
		}

		[XmlElement("overdue_interest")]
		public string OverdueInterest
		{
			get;
			set;
		}

		[XmlElement("overdue_interest_penalty")]
		public string OverdueInterestPenalty
		{
			get;
			set;
		}

		[XmlElement("overdue_principal")]
		public string OverduePrincipal
		{
			get;
			set;
		}

		[XmlElement("overdue_principal_penalty")]
		public string OverduePrincipalPenalty
		{
			get;
			set;
		}

		[XmlElement("principal")]
		public string Principal
		{
			get;
			set;
		}

		[XmlElement("remarks")]
		public string Remarks
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
