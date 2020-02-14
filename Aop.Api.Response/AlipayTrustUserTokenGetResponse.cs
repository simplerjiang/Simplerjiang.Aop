using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTrustUserTokenGetResponse : AopResponse
	{
		[XmlElement("access_token")]
		public string AccessToken
		{
			get;
			set;
		}

		[XmlElement("refresh_token")]
		public string RefreshToken
		{
			get;
			set;
		}
	}
}
