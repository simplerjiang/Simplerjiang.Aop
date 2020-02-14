using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardTemplateCreateResponse : AopResponse
	{
		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
