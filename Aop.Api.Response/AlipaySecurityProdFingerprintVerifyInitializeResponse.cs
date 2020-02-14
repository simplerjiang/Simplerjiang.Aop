using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFingerprintVerifyInitializeResponse : AopResponse
	{
		[XmlElement("server_response")]
		public string ServerResponse
		{
			get;
			set;
		}
	}
}
