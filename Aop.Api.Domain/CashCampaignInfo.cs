using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CashCampaignInfo : AopObject
	{
		[XmlElement("camp_status")]
		public string CampStatus
		{
			get;
			set;
		}

		[XmlElement("coupon_name")]
		public string CouponName
		{
			get;
			set;
		}

		[XmlElement("crowd_no")]
		public string CrowdNo
		{
			get;
			set;
		}

		[XmlElement("origin_crowd_no")]
		public string OriginCrowdNo
		{
			get;
			set;
		}
	}
}
