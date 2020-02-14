using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMenuQueryResponse : AopResponse
	{
		[XmlElement("menu_content")]
		public string MenuContent
		{
			get;
			set;
		}
	}
}
