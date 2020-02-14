using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieTemplateQueryResponse : AopResponse
	{
		[XmlArray("template")]
		[XmlArrayItem("fengdie_template")]
		public List<FengdieTemplate> Template
		{
			get;
			set;
		}
	}
}
