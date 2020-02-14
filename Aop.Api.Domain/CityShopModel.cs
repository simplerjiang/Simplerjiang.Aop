using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CityShopModel : AopObject
	{
		[XmlElement("city_id")]
		public string CityId
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

		[XmlElement("district_id")]
		public string DistrictId
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

		[XmlElement("pos_shop")]
		public bool PosShop
		{
			get;
			set;
		}

		[XmlElement("province_id")]
		public string ProvinceId
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

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlElement("shop_status")]
		public string ShopStatus
		{
			get;
			set;
		}
	}
}
