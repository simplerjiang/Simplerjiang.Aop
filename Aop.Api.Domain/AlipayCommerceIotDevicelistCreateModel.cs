using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotDevicelistCreateModel : AopObject
	{
		[XmlArray("device_list")]
		[XmlArrayItem("iot_device")]
		public List<IotDevice> DeviceList
		{
			get;
			set;
		}

		[XmlArray("device_personal_info_list")]
		[XmlArrayItem("iot_device_personal_info")]
		public List<IotDevicePersonalInfo> DevicePersonalInfoList
		{
			get;
			set;
		}

		[XmlElement("protocol_supplier_id")]
		public string ProtocolSupplierId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
