using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignIntelligentTemplateConsultResponse : AopResponse
	{
		[XmlArray("template_codes")]
		[XmlArrayItem("string")]
		public List<string> TemplateCodes
		{
			get;
			set;
		}
	}
}
