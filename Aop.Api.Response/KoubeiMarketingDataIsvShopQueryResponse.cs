using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataIsvShopQueryResponse : AopResponse
	{
		[XmlArray("shop_summary_infos")]
		[XmlArrayItem("shop_summary_info")]
		public List<ShopSummaryInfo> ShopSummaryInfos
		{
			get;
			set;
		}
	}
}
