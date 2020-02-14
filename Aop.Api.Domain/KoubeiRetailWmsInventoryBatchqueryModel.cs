using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInventoryBatchqueryModel : AopObject
	{
		[XmlArray("goods_code_list")]
		[XmlArrayItem("string")]
		public List<string> GoodsCodeList
		{
			get;
			set;
		}

		[XmlElement("inventory_type")]
		public string InventoryType
		{
			get;
			set;
		}

		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}
	}
}
