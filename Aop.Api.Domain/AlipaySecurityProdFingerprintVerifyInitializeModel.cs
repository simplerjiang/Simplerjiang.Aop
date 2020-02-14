using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdFingerprintVerifyInitializeModel : AopObject
	{
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

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
