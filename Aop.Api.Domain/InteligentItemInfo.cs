using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentItemInfo : AopObject
	{
		[XmlArray("item_ids")]
		[XmlArrayItem("string")]
		public List<string> ItemIds
		{
			get;
			set;
		}

		[XmlArray("item_imgs")]
		[XmlArrayItem("string")]
		public List<string> ItemImgs
		{
			get;
			set;
		}

		[XmlElement("item_link")]
		public string ItemLink
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("item_text")]
		public string ItemText
		{
			get;
			set;
		}

		[XmlElement("max_discount_num")]
		public string MaxDiscountNum
		{
			get;
			set;
		}

		[XmlElement("min_consume_num")]
		public string MinConsumeNum
		{
			get;
			set;
		}

		[XmlElement("original_price")]
		public string OriginalPrice
		{
			get;
			set;
		}

		[XmlElement("sku_min_consume")]
		public string SkuMinConsume
		{
			get;
			set;
		}

		[XmlElement("total_max_discount_num")]
		public string TotalMaxDiscountNum
		{
			get;
			set;
		}
	}
}
