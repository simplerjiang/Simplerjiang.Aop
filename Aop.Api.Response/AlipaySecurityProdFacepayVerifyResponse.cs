using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFacepayVerifyResponse : AopResponse
	{
		[XmlElement("ftoken")]
		public string Ftoken
		{
			get;
			set;
		}
	}
}
