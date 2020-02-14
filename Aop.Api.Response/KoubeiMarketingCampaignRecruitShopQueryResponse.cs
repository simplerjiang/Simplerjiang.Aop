using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignRecruitShopQueryResponse : AopResponse
	{
		[XmlElement("plan_id")]
		public string PlanId
		{
			get;
			set;
		}

		[XmlElement("shop_count")]
		public string ShopCount
		{
			get;
			set;
		}

		[XmlArray("shop_info")]
		[XmlArrayItem("recruit_shop_info")]
		public List<RecruitShopInfo> ShopInfo
		{
			get;
			set;
		}
	}
}
