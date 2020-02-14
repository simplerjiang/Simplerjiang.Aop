using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtShopItem : AopObject
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

		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("country")]
		public string Country
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

		[XmlElement("ext_goods_info")]
		public string ExtGoodsInfo
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
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

		[XmlElement("picture")]
		public string Picture
		{
			get;
			set;
		}

		[XmlElement("price")]
		public long Price
		{
			get;
			set;
		}

		[XmlElement("specification")]
		public string Specification
		{
			get;
			set;
		}

		[XmlElement("system_provider_id")]
		public string SystemProviderId
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
