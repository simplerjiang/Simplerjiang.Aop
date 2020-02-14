using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AddressInfo : AopObject
	{
		[XmlElement("address")]
		public string Address
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

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
