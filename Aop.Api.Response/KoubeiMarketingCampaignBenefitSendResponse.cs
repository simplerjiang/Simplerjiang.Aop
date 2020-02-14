using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignBenefitSendResponse : AopResponse
	{
		[XmlArray("benefit_ids")]
		[XmlArrayItem("string")]
		public List<string> BenefitIds
		{
			get;
			set;
		}
	}
}
