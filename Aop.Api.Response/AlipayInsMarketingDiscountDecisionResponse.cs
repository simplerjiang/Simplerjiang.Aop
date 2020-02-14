using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingDiscountDecisionResponse : AopResponse
	{
		[XmlArray("mkt_coupon_campaigns")]
		[XmlArrayItem("ins_mkt_coupon_campaign_d_t_o")]
		public List<InsMktCouponCampaignDTO> MktCouponCampaigns
		{
			get;
			set;
		}

		[XmlArray("mkt_coupons")]
		[XmlArrayItem("ins_mkt_coupon_d_t_o")]
		public List<InsMktCouponDTO> MktCoupons
		{
			get;
			set;
		}
	}
}
