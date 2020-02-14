using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignIntelligentPromoBatchqueryResponse : AopResponse
	{
		[XmlArray("intelligent_promos")]
		[XmlArrayItem("intelligent_promo")]
		public List<IntelligentPromo> IntelligentPromos
		{
			get;
			set;
		}

		[XmlElement("page_result")]
		public PromoPageResult PageResult
		{
			get;
			set;
		}
	}
}
