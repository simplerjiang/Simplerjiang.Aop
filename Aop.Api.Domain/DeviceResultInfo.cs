using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeviceResultInfo : AopObject
	{
		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("device_label")]
		public string DeviceLabel
		{
			get;
			set;
		}
	}
}
