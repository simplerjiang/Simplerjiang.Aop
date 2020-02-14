using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAccountDeviceInfoQueryModel : AopObject
	{
		[XmlArray("device_ids")]
		[XmlArrayItem("string")]
		public List<string> DeviceIds
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

		[XmlElement("encrypt_type")]
		public string EncryptType
		{
			get;
			set;
		}

		[XmlElement("extra_info")]
		public string ExtraInfo
		{
			get;
			set;
		}

		[XmlElement("request_from")]
		public string RequestFrom
		{
			get;
			set;
		}
	}
}
