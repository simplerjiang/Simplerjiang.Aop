using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAuthZhimaperInternalApplyResponse : AopResponse
	{
		[XmlElement("access_token")]
		public string AccessToken
		{
			get;
			set;
		}

		[XmlElement("auth_token_type")]
		public string AuthTokenType
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
