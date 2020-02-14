using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailShopitemUploadModel : AopObject
	{
		[XmlArray("shop_items")]
		[XmlArrayItem("request_ext_shop_item")]
		public List<RequestExtShopItem> ShopItems
		{
			get;
			set;
		}
	}
}
