using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopSummaryQueryResponse : AopObject
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

		[XmlElement("district_code")]
		public string DistrictCode
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("is_show")]
		public string IsShow
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

		[XmlElement("main_image")]
		public string MainImage
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

		[XmlElement("pic_coll")]
		public string PicColl
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

		[XmlElement("shop_comment_info")]
		public ShopCommentInfo ShopCommentInfo
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
