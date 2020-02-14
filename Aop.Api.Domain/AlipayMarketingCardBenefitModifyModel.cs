using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardBenefitModifyModel : AopObject
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlElement("mcard_template_benefit")]
		public McardTemplateBenefit McardTemplateBenefit
		{
			get;
			set;
		}
	}
}
