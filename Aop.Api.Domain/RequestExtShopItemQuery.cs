using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RequestExtShopItemQuery : AopObject
	{
		[XmlElement("brand_code")]
		public string BrandCode
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}

		[XmlElement("kb_shop_id")]
		public string KbShopId
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

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
