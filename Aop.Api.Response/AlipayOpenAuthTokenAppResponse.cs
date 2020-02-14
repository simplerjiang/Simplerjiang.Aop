using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAuthTokenAppResponse : AopResponse
	{
		[XmlElement("app_auth_token")]
		public string AppAuthToken
		{
			get;
			set;
		}

		[XmlElement("app_refresh_token")]
		public string AppRefreshToken
		{
			get;
			set;
		}

		[XmlElement("auth_app_id")]
		public string AuthAppId
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

		[XmlArray("tokens")]
		[XmlArrayItem("app_token_exchange_sub_element")]
		public List<AppTokenExchangeSubElement> Tokens
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
