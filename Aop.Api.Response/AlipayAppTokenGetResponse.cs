using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAppTokenGetResponse : AopResponse
	{
		[XmlElement("app_access_token")]
		public string AppAccessToken
		{
			get;
			set;
		}

		[XmlElement("expires_in")]
		public long ExpiresIn
		{
			get;
			set;
		}
	}
}
