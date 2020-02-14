using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffPurchaseorderQueryResponse : AopResponse
	{
		[XmlArray("asset_purchase_orders")]
		[XmlArrayItem("access_purchase_order")]
		public List<AccessPurchaseOrder> AssetPurchaseOrders
		{
			get;
			set;
		}

		[XmlElement("has_next_page")]
		public bool HasNextPage
		{
			get;
			set;
		}
	}
}
