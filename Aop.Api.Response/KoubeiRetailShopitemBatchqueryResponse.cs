using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailShopitemBatchqueryResponse : AopResponse
	{
		[XmlArray("shopitemlist")]
		[XmlArrayItem("ext_shop_item")]
		public List<ExtShopItem> Shopitemlist
		{
			get;
			set;
		}
	}
}
