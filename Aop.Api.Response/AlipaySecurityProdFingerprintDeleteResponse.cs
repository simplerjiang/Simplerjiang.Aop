using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFingerprintDeleteResponse : AopResponse
	{
		[XmlElement("server_response")]
		public string ServerResponse
		{
			get;
			set;
		}
	}
}
