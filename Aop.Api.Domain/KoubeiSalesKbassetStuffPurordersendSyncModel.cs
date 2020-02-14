using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffPurordersendSyncModel : AopObject
	{
		[XmlArray("purchase_order_sends")]
		[XmlArrayItem("access_purchase_order_send")]
		public List<AccessPurchaseOrderSend> PurchaseOrderSends
		{
			get;
			set;
		}
	}
}
