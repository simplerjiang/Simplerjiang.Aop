using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingToolPrizesendAuthResponse : AopResponse
	{
		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
