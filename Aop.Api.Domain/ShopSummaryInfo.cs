using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopSummaryInfo : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("branch_shop_name")]
		public string BranchShopName
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

		[XmlElement("business_time")]
		public string BusinessTime
		{
			get;
			set;
		}

		[XmlArray("category_infos")]
		[XmlArrayItem("shop_category_info")]
		public List<ShopCategoryInfo> CategoryInfos
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("city_name")]
		public string CityName
		{
			get;
			set;
		}

		[XmlElement("display_status")]
		public string DisplayStatus
		{
			get;
			set;
		}

		[XmlElement("district_code")]
		public string DistrictCode
		{
			get;
			set;
		}

		[XmlElement("district_name")]
		public string DistrictName
		{
			get;
			set;
		}

		[XmlElement("landline_no")]
		public string LandlineNo
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

		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlElement("logo_url")]
		public string LogoUrl
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

		[XmlElement("main_image")]
		public string MainImage
		{
			get;
			set;
		}

		[XmlElement("main_image_url")]
		public string MainImageUrl
		{
			get;
			set;
		}

		[XmlElement("main_shop_name")]
		public string MainShopName
		{
			get;
			set;
		}

		[XmlElement("mobile_no")]
		public string MobileNo
		{
			get;
			set;
		}

		[XmlElement("per_pay")]
		public string PerPay
		{
			get;
			set;
		}

		[XmlElement("principal_id")]
		public string PrincipalId
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("province_name")]
		public string ProvinceName
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
