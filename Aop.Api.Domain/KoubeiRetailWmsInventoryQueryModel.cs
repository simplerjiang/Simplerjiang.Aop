using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInventoryQueryModel : AopObject
	{
		[XmlElement("batch_code")]
		public string BatchCode
		{
			get;
			set;
		}

		[XmlElement("goods_code")]
		public string GoodsCode
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

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
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
