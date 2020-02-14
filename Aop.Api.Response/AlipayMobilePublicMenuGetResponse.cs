using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicMenuGetResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("menu_content")]
		public string MenuContent
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
