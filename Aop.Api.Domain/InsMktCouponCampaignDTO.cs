using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktCouponCampaignDTO : AopObject
	{
		[XmlElement("campaign_end_time")]
		public string CampaignEndTime
		{
			get;
			set;
		}

		[XmlElement("campaign_id")]
		public string CampaignId
		{
			get;
			set;
		}

		[XmlElement("campaign_memo")]
		public string CampaignMemo
		{
			get;
			set;
		}

		[XmlElement("campaign_name")]
		public string CampaignName
		{
			get;
			set;
		}

		[XmlElement("campaign_start_time")]
		public string CampaignStartTime
		{
			get;
			set;
		}

		[XmlElement("coupon_type")]
		public string CouponType
		{
			get;
			set;
		}

		[XmlElement("coupon_upper_value")]
		public string CouponUpperValue
		{
			get;
			set;
		}

		[XmlElement("coupon_value")]
		public string CouponValue
		{
			get;
			set;
		}
	}
}
