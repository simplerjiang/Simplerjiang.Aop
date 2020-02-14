using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicPartnerMenuQueryResponse : AopResponse
	{
		[XmlElement("public_menu")]
		public string PublicMenu
		{
			get;
			set;
		}
	}
}
