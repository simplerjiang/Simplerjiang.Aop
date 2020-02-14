using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardBenefitQueryModel : AopObject
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
