using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class WarehouseVO : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("area_code")]
		public string AreaCode
		{
			get;
			set;
		}

		[XmlElement("area_name")]
		public string AreaName
		{
			get;
			set;
		}

		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("cainiao_code")]
		public string CainiaoCode
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

		[XmlElement("contact")]
		public string Contact
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

		[XmlElement("owner_id")]
		public string OwnerId
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
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

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}

		[XmlElement("warehouse_name")]
		public string WarehouseName
		{
			get;
			set;
		}

		[XmlElement("warehouse_type")]
		public string WarehouseType
		{
			get;
			set;
		}
	}
}
