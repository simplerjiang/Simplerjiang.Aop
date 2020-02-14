using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarViolationCityPushModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("push_type")]
		public string PushType
		{
			get;
			set;
		}

		[XmlElement("service_status")]
		public string ServiceStatus
		{
			get;
			set;
		}
	}
}
