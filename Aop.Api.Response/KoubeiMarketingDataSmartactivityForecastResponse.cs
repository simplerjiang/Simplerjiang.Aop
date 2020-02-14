using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataSmartactivityForecastResponse : AopResponse
	{
		[XmlElement("apply_cnt_max")]
		public string ApplyCntMax
		{
			get;
			set;
		}

		[XmlElement("apply_cnt_min")]
		public string ApplyCntMin
		{
			get;
			set;
		}

		[XmlElement("increased_exposure_max")]
		public string IncreasedExposureMax
		{
			get;
			set;
		}

		[XmlElement("increased_exposure_min")]
		public string IncreasedExposureMin
		{
			get;
			set;
		}

		[XmlElement("repay_rate_range_max")]
		public string RepayRateRangeMax
		{
			get;
			set;
		}

		[XmlElement("repay_rate_range_min")]
		public string RepayRateRangeMin
		{
			get;
			set;
		}

		[XmlElement("trade_amt_range_max")]
		public string TradeAmtRangeMax
		{
			get;
			set;
		}

		[XmlElement("trade_amt_range_min")]
		public string TradeAmtRangeMin
		{
			get;
			set;
		}

		[XmlElement("verify_count_range_max")]
		public string VerifyCountRangeMax
		{
			get;
			set;
		}

		[XmlElement("verify_count_range_min")]
		public string VerifyCountRangeMin
		{
			get;
			set;
		}
	}
}
