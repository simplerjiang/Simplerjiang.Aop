using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySystemOauthTokenResponse : AopResponse
	{
		[XmlElement("access_token")]
		public string AccessToken
		{
			get;
			set;
		}

		[XmlElement("alipay_user_id")]
		public string AlipayUserId
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

		[XmlElement("expires_in")]
		public string ExpiresIn
		{
			get;
			set;
		}

		[XmlElement("re_expires_in")]
		public string ReExpiresIn
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
