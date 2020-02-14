using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingMallShoppromoinfoQueryResponse : AopResponse
	{
		[XmlArray("shop_promo_infos")]
		[XmlArrayItem("shop_promo_info")]
		public List<ShopPromoInfo> ShopPromoInfos
		{
			get;
			set;
		}
	}
}
