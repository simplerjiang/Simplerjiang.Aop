using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishCookDetailInfo : AopObject
	{
		[XmlElement("catetory_big_id")]
		public string CatetoryBigId
		{
			get;
			set;
		}

		[XmlElement("catetory_small_id")]
		public string CatetorySmallId
		{
			get;
			set;
		}

		[XmlElement("cook_id")]
		public string CookId
		{
			get;
			set;
		}

		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlElement("flag")]
		public string Flag
		{
			get;
			set;
		}

		[XmlArray("kb_cook_sku_price_list")]
		[XmlArrayItem("kbdish_cook_price_info")]
		public List<KbdishCookPriceInfo> KbCookSkuPriceList
		{
			get;
			set;
		}

		[XmlElement("sort")]
		public string Sort
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
