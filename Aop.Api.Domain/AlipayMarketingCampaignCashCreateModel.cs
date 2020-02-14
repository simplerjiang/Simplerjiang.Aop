using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignCashCreateModel : AopObject
	{
		[XmlElement("coupon_name")]
		public string CouponName
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("merchant_link")]
		public string MerchantLink
		{
			get;
			set;
		}

		[XmlElement("prize_msg")]
		public string PrizeMsg
		{
			get;
			set;
		}

		[XmlElement("prize_type")]
		public string PrizeType
		{
			get;
			set;
		}

		[XmlElement("send_freqency")]
		public string SendFreqency
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("total_money")]
		public string TotalMoney
		{
			get;
			set;
		}

		[XmlElement("total_num")]
		public string TotalNum
		{
			get;
			set;
		}
	}
}
