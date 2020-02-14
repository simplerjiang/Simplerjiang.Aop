using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingCampaignDecisionResponse : AopResponse
	{
		[XmlArray("mkt_campaigns")]
		[XmlArrayItem("ins_mkt_campaign_d_t_o")]
		public List<InsMktCampaignDTO> MktCampaigns
		{
			get;
			set;
		}
	}
}
