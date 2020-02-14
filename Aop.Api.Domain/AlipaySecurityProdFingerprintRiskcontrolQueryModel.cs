using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFingerprintRiskcontrolQueryModel : AopObject
	{
		[XmlElement("aaid")]
		public string Aaid
		{
			get;
			set;
		}

		[XmlElement("auth_type")]
		public string AuthType
		{
			get;
			set;
		}

		[XmlElement("build_model")]
		public string BuildModel
		{
			get;
			set;
		}

		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}
	}
}
