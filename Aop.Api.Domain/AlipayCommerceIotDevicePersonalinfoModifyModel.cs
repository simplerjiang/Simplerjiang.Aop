using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotDevicePersonalinfoModifyModel : AopObject
	{
		[XmlElement("device_personal_info")]
		public IotDevicePersonalInfo DevicePersonalInfo
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
