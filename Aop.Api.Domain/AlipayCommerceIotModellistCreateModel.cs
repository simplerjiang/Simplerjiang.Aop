using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotModellistCreateModel : AopObject
	{
		[XmlArray("model_list")]
		[XmlArrayItem("iot_device_model")]
		public List<IotDeviceModel> ModelList
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
