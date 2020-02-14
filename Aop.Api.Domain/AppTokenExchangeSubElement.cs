using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AppTokenExchangeSubElement : AopObject
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
