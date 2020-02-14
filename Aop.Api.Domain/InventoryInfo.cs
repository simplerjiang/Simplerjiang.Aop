using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InventoryInfo : AopObject
	{
		[XmlElement("quantity")]
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("sku_id")]
		public string SkuId
		{
			get;
			set;
		}
	}
}
