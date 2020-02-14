using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OutboundOrderLine : AopObject
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

		[XmlElement("plan_quantity")]
		public long PlanQuantity
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
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

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}
	}
}
