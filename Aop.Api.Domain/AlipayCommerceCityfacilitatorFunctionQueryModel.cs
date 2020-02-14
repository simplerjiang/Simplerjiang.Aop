using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorFunctionQueryModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("device_code")]
		public string DeviceCode
		{
			get;
			set;
		}
	}
}
