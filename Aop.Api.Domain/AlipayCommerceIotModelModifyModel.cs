using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotModelModifyModel : AopObject
	{
		[XmlElement("model")]
		public IotDeviceModel Model
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
	}
}
