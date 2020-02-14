using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskDigitalidentityQueryModel : AopObject
	{
		[XmlElement("device_code")]
		public string DeviceCode
		{
			get;
			set;
		}
	}
}
