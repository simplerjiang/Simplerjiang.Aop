using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskDeviceidentityQueryModel : AopObject
	{
		[XmlElement("device_token")]
		public string DeviceToken
		{
			get;
			set;
		}
	}
}
