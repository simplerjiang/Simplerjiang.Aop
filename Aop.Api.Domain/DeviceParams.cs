using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeviceParams : AopObject
	{
		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("device_name")]
		public string DeviceName
		{
			get;
			set;
		}

		[XmlElement("device_type")]
		public string DeviceType
		{
			get;
			set;
		}
	}
}
