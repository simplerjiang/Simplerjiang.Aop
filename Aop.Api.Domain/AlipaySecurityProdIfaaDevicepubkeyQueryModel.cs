using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdIfaaDevicepubkeyQueryModel : AopObject
	{
		[XmlElement("ecdh_publickey")]
		public string EcdhPublickey
		{
			get;
			set;
		}

		[XmlElement("max_id")]
		public string MaxId
		{
			get;
			set;
		}

		[XmlElement("security_device_id")]
		public string SecurityDeviceId
		{
			get;
			set;
		}

		[XmlElement("security_schema")]
		public string SecuritySchema
		{
			get;
			set;
		}
	}
}
