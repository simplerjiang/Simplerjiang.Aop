using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotDeviceDeleteModel : AopObject
	{
		[XmlElement("device_id")]
		public string DeviceId
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
