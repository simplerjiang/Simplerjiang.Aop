using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicMenuQueryResponse : AopResponse
	{
		[XmlElement("all_menu_list")]
		public string AllMenuList
		{
			get;
			set;
		}

		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
