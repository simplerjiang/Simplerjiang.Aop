using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardBenefitQueryResponse : AopResponse
	{
		[XmlArray("mcard_template_benefit_query")]
		[XmlArrayItem("mcard_template_benefit_query")]
		public List<McardTemplateBenefitQuery> McardTemplateBenefitQuery
		{
			get;
			set;
		}
	}
}
