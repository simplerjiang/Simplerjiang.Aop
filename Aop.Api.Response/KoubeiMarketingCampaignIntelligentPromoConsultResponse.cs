using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignIntelligentPromoConsultResponse : AopResponse
	{
		[XmlElement("promo")]
		public IntelligentPromo Promo
		{
			get;
			set;
		}
	}
}
