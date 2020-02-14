using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardTemplateBatchqueryResponse : AopResponse
	{
		[XmlArray("mcard_template")]
		[XmlArrayItem("mcard_template")]
		public List<McardTemplate> McardTemplate
		{
			get;
			set;
		}

		[XmlElement("template_total")]
		public long TemplateTotal
		{
			get;
			set;
		}
	}
}
