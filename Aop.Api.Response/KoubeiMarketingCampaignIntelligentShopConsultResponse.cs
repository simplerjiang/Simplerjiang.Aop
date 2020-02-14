using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignIntelligentShopConsultResponse : AopResponse
	{
		[XmlElement("items")]
		public string Items
		{
			get;
			set;
		}

		[XmlArray("shops")]
		[XmlArrayItem("intelligent_promo_shop_summary_info")]
		public List<IntelligentPromoShopSummaryInfo> Shops
		{
			get;
			set;
		}
	}
}
