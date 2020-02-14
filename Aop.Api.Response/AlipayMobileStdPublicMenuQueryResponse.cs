using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileStdPublicMenuQueryResponse : AopResponse
	{
		[XmlElement("all_menu_list")]
		public string AllMenuList
		{
			get;
			set;
		}
	}
}
