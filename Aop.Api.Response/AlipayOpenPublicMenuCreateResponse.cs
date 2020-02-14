using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMenuCreateResponse : AopResponse
	{
		[XmlElement("menu_key")]
		public string MenuKey
		{
			get;
			set;
		}
	}
}
