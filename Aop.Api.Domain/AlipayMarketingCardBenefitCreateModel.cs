using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardBenefitCreateModel : AopObject
	{
		[XmlElement("mcard_template_benefit")]
		public McardTemplateBenefit McardTemplateBenefit
		{
			get;
			set;
		}
	}
}
