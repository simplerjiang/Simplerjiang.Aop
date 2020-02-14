using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RegionInfo : AopObject
	{
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
	}
}
