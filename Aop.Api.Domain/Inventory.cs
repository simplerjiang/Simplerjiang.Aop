using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Inventory : AopObject
	{
		[XmlElement("batch_code")]
		public string BatchCode
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("extend_props")]
		public string ExtendProps
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
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

		[XmlElement("lock_quantity")]
		public long LockQuantity
		{
			get;
			set;
		}

		[XmlElement("product_date")]
		public string ProductDate
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("real_quantity")]
		public long RealQuantity
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
