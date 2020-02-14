using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AopResponse
	{
		[XmlElement("promo")]
		public IntelligentPromo Promo
		{
			get;
			set;
		}
	}
}
