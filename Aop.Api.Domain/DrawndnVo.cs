using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DrawndnVo : AopObject
	{
		[XmlElement("actual_collected_interest")]
		public string ActualCollectedInterest
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("collected_principal_and_interest")]
		public string CollectedPrincipalAndInterest
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

		[XmlElement("drawndn_date")]
		public string DrawndnDate
		{
			get;
			set;
		}

		[XmlElement("drawndn_no")]
		public string DrawndnNo
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

		[XmlElement("five_tier_classification")]
		public string FiveTierClassification
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

		[XmlElement("interest_rate")]
		public string InterestRate
		{
			get;
			set;
		}

		[XmlElement("lending_amount")]
		public string LendingAmount
		{
			get;
			set;
		}

		[XmlElement("overduce_terms")]
		public long OverduceTerms
		{
			get;
			set;
		}

		[XmlElement("overdue_days")]
		public long OverdueDays
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
