using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class WorkDetail : AopObject
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

		[XmlElement("ext_info")]
		public string ExtInfo
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

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("production_date")]
		public string ProductionDate
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
	}
}
