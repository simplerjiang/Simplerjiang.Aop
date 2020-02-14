using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicMenuUserQueryResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("menu_key")]
		public string MenuKey
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
