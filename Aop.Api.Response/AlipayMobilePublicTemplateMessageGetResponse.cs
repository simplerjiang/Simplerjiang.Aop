using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicTemplateMessageGetResponse : AopResponse
	{
		[XmlElement("msg_template_id")]
		public string MsgTemplateId
		{
			get;
			set;
		}

		[XmlElement("template")]
		public string Template
		{
			get;
			set;
		}
	}
}
