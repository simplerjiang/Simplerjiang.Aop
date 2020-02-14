using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktPreUseCampaignDTO : AopObject
	{
		[XmlElement("campaign_id")]
		public string CampaignId
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

		[XmlElement("pre_use")]
		public bool PreUse
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
		{
			get;
			set;
		}
	}
}
