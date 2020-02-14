using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoBasicRouterSendResponse : AopResponse
	{
		[XmlElement("res")]
		public string Res
		{
			get;
			set;
		}
	}
}
