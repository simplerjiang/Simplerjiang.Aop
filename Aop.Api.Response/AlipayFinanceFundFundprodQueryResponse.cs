using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceFundFundprodQueryResponse : AopResponse
	{
		[XmlElement("establishment_date")]
		public string EstablishmentDate
		{
			get;
			set;
		}

		[XmlElement("fund_code")]
		public string FundCode
		{
			get;
			set;
		}

		[XmlElement("fund_name")]
		public string FundName
		{
			get;
			set;
		}

		[XmlElement("fund_name_abbr")]
		public string FundNameAbbr
		{
			get;
			set;
		}

		[XmlElement("net_value")]
		public string NetValue
		{
			get;
			set;
		}

		[XmlElement("net_value_date")]
		public string NetValueDate
		{
			get;
			set;
		}

		[XmlElement("profit_seven_days")]
		public string ProfitSevenDays
		{
			get;
			set;
		}

		[XmlElement("profit_ten_thousand")]
		public string ProfitTenThousand
		{
			get;
			set;
		}

		[XmlElement("risk_evaluation")]
		public string RiskEvaluation
		{
			get;
			set;
		}
	}
}
