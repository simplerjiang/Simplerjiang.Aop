using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardBenefitCreateResponse : AopResponse
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}
	}
}
