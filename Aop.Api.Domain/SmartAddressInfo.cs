using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SmartAddressInfo : AopObject
	{
		[XmlElement("area_code")]
		public long AreaCode
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public long CityCode
		{
			get;
			set;
		}

		[XmlElement("machine_address")]
		public string MachineAddress
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public long ProvinceCode
		{
			get;
			set;
		}
	}
}
