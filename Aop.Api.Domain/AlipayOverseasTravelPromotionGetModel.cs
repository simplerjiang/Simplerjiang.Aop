using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelPromotionGetModel : AopObject
	{
		[XmlArray("biz_area_codes")]
		[XmlArrayItem("string")]
		public List<string> BizAreaCodes
		{
			get;
			set;
		}

		[XmlElement("ch_info")]
		public string ChInfo
		{
			get;
			set;
		}

		[XmlArray("city_codes")]
		[XmlArrayItem("string")]
		public List<string> CityCodes
		{
			get;
			set;
		}

		[XmlArray("country_codes")]
		[XmlArrayItem("string")]
		public List<string> CountryCodes
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

		[XmlElement("lbs_reverse_level")]
		public string LbsReverseLevel
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

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("radius")]
		public long Radius
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
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

		[XmlArray("top_promotion_ids")]
		[XmlArrayItem("string")]
		public List<string> TopPromotionIds
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("user_id_type")]
		public string UserIdType
		{
			get;
			set;
		}
	}
}
