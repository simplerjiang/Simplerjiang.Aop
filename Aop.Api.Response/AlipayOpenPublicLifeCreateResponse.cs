using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeCreateResponse : AopResponse
	{
		[XmlElement("expire_time")]
		public string ExpireTime
		{
			get;
			set;
		}

		[XmlElement("public_id")]
		public string PublicId
		{
			get;
			set;
		}

		[XmlElement("public_long_link")]
		public string PublicLongLink
		{
			get;
			set;
		}

		[XmlElement("public_short_link")]
		public string PublicShortLink
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

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
