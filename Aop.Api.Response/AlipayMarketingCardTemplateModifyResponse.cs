using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardTemplateModifyResponse : AopResponse
	{
		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
