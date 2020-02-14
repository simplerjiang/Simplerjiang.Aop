using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PaymentSchedule : AopObject
	{
		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("repaid_interest_total")]
		public string RepaidInterestTotal
		{
			get;
			set;
		}

		[XmlElement("repaid_penalty_total")]
		public string RepaidPenaltyTotal
		{
			get;
			set;
		}

		[XmlElement("repaid_principal_total")]
		public string RepaidPrincipalTotal
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
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

		[XmlElement("unpaid_interest_total")]
		public string UnpaidInterestTotal
		{
			get;
			set;
		}

		[XmlElement("unpaid_penalty_total")]
		public string UnpaidPenaltyTotal
		{
			get;
			set;
		}

		[XmlElement("unpaid_principal_total")]
		public string UnpaidPrincipalTotal
		{
			get;
			set;
		}
	}
}
