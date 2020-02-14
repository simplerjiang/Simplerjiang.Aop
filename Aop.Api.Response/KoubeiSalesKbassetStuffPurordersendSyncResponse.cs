using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffPurordersendSyncResponse : AopResponse
	{
		[XmlArray("purchase_order_send_results")]
		[XmlArrayItem("access_purchase_order_send_result")]
		public List<AccessPurchaseOrderSendResult> PurchaseOrderSendResults
		{
			get;
			set;
		}
	}
}
