using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingDiscountPreuseResponse : AopResponse
	{
		[XmlArray("pre_use_campaigns")]
		[XmlArrayItem("ins_mkt_pre_use_campaign_d_t_o")]
		public List<InsMktPreUseCampaignDTO> PreUseCampaigns
		{
			get;
			set;
		}

		[XmlArray("pre_use_coupons")]
		[XmlArrayItem("ins_mkt_pre_use_coupon_d_t_o")]
		public List<InsMktPreUseCouponDTO> PreUseCoupons
		{
			get;
			set;
		}
	}
}
