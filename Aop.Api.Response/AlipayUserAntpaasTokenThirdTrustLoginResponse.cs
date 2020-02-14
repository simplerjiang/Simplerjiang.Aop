using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasTokenThirdTrustLoginResponse : AopResponse
	{
		[XmlElement("third_trust_token")]
		public string ThirdTrustToken
		{
			get;
			set;
		}
	}
}
