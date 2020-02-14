using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainShopCreateModel : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("alipay_account")]
		public string AlipayAccount
		{
			get;
			set;
		}

		[XmlArray("brand_ids")]
		[XmlArrayItem("string")]
		public List<string> BrandIds
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

		[XmlElement("close_time")]
		public string CloseTime
		{
			get;
			set;
		}

		[XmlElement("contact_email")]
		public string ContactEmail
		{
			get;
			set;
		}

		[XmlElement("contact_mobile_phone")]
		public string ContactMobilePhone
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
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

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlArray("industry_app_category_id")]
		[XmlArrayItem("number")]
		public List<long> IndustryAppCategoryId
		{
			get;
			set;
		}

		[XmlArray("industry_category_id")]
		[XmlArrayItem("number")]
		public List<long> IndustryCategoryId
		{
			get;
			set;
		}

		[XmlElement("lat")]
		public string Lat
		{
			get;
			set;
		}

		[XmlElement("lon")]
		public string Lon
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

		[XmlElement("merchant_branch_id")]
		public long MerchantBranchId
		{
			get;
			set;
		}

		[XmlElement("open_time")]
		public string OpenTime
		{
			get;
			set;
		}

		[XmlArray("other_images")]
		[XmlArrayItem("string")]
		public List<string> OtherImages
		{
			get;
			set;
		}

		[XmlElement("out_shop_id")]
		public string OutShopId
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

		[XmlElement("shop_branch_name")]
		public string ShopBranchName
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

		[XmlElement("shop_tel")]
		public string ShopTel
		{
			get;
			set;
		}

		[XmlElement("shop_type")]
		public string ShopType
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
