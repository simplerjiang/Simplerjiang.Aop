using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFingerprintVerifyResponse : AopResponse
	{
		[XmlElement("auth_result")]
		public bool AuthResult
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
