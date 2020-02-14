using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopRec : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("busi_area")]
		public string BusiArea
		{
			get;
			set;
		}

		[XmlElement("city_id")]
		public string CityId
		{
			get;
			set;
		}

		[XmlElement("cuisine")]
		public string Cuisine
		{
			get;
			set;
		}

		[XmlElement("distance")]
		public string Distance
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

		[XmlElement("has_hui")]
		public string HasHui
		{
			get;
			set;
		}

		[XmlElement("head_shop_name")]
		public string HeadShopName
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("popularity")]
		public string Popularity
		{
			get;
			set;
		}

		[XmlElement("popularity_level")]
		public string PopularityLevel
		{
			get;
			set;
		}

		[XmlElement("price_average")]
		public string PriceAverage
		{
			get;
			set;
		}

		[XmlElement("root_display_category_info")]
		public string RootDisplayCategoryInfo
		{
			get;
			set;
		}

		[XmlElement("shop_detail_url")]
		public string ShopDetailUrl
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_logo_url")]
		public string ShopLogoUrl
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlElement("shop_recommend_one_tag_compose")]
		public string ShopRecommendOneTagCompose
		{
			get;
			set;
		}

		[XmlArray("voucher_list")]
		[XmlArrayItem("voucher_rec")]
		public List<VoucherRec> VoucherList
		{
			get;
			set;
		}
	}
}
