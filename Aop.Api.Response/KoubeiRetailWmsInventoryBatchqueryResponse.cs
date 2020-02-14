using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInventoryBatchqueryResponse : AopResponse
	{
		[XmlArray("inventory_list")]
		[XmlArrayItem("inventory")]
		public List<Inventory> InventoryList
		{
			get;
			set;
		}
	}
}
