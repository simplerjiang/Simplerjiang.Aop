using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishCookPriceInfo : AopObject
	{
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

		[XmlElement("member_price")]
		public string MemberPrice
		{
			get;
			set;
		}

		[XmlElement("sell_price")]
		public string SellPrice
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
