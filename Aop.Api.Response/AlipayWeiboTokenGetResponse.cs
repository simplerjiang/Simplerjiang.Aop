using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayWeiboTokenGetResponse : AopResponse
	{
		[XmlElement("access_token")]
		public string AccessToken
		{
			get;
			set;
		}
	}
}
