using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAuthIndustryPlatformCreateTokenResponse : AopResponse
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlElement("requst_app_id")]
		public string RequstAppId
		{
			get;
			set;
		}

		[XmlElement("scope")]
		public string Scope
		{
			get;
			set;
		}
	}
}
