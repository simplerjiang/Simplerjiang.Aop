using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFingerprintApplyInitializeModel : AopObject
	{
		[XmlElement("auth_type")]
		public string AuthType
		{
			get;
			set;
		}

		[XmlElement("ifaa_version")]
		public string IfaaVersion
		{
			get;
			set;
		}

		[XmlElement("sec_data")]
		public string SecData
		{
			get;
			set;
		}
	}
}
