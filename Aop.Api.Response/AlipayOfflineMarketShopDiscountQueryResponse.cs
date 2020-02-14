using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopDiscountQueryResponse : AopResponse
	{
		[XmlArray("camp_list")]
		[XmlArrayItem("camp_detail_info")]
		public List<CampDetailInfo> CampList
		{
			get;
			set;
		}

		[XmlElement("camp_num")]
		public long CampNum
		{
			get;
			set;
		}

		[XmlArray("discount_list")]
		[XmlArrayItem("shop_discount_info")]
		public List<ShopDiscountInfo> DiscountList
		{
			get;
			set;
		}

		[XmlArray("item_list")]
		[XmlArrayItem("shop_discount_info")]
		public List<ShopDiscountInfo> ItemList
		{
			get;
			set;
		}
	}
}
