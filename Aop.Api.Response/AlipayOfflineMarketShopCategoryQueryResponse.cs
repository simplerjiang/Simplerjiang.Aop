using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopCategoryQueryResponse : AopResponse
	{
		[XmlArray("shop_category_config_infos")]
		[XmlArrayItem("shop_category_config_info")]
		public List<ShopCategoryConfigInfo> ShopCategoryConfigInfos
		{
			get;
			set;
		}
	}
}
