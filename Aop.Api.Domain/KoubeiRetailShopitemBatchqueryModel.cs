using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailShopitemBatchqueryModel : AopObject
	{
		[XmlArray("shop_items")]
		[XmlArrayItem("request_ext_shop_item_query")]
		public List<RequestExtShopItemQuery> ShopItems
		{
			get;
			set;
		}
	}
}
