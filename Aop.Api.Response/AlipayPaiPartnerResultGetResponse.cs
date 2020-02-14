using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPaiPartnerResultGetResponse : AopResponse
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("oauth_token")]
		public string OauthToken
		{
			get;
			set;
		}

		[XmlElement("route_method")]
		public string RouteMethod
		{
			get;
			set;
		}
	}
}
