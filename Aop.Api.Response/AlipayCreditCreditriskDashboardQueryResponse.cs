using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditCreditriskDashboardQueryResponse : AopResponse
	{
		[XmlElement("credit_loan")]
		public string CreditLoan
		{
			get;
			set;
		}

		[XmlElement("sale_refund")]
		public string SaleRefund
		{
			get;
			set;
		}

		[XmlElement("service_charge")]
		public string ServiceCharge
		{
			get;
			set;
		}

		[XmlElement("total_income")]
		public string TotalIncome
		{
			get;
			set;
		}

		[XmlElement("total_payout")]
		public string TotalPayout
		{
			get;
			set;
		}

		[XmlElement("tqsk_loan")]
		public string TqskLoan
		{
			get;
			set;
		}

		[XmlElement("ylb_profit")]
		public string YlbProfit
		{
			get;
			set;
		}
	}
}
