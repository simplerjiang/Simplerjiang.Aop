using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleRulelistQueryResponse : AopResponse
	{
		[XmlArray("rulelist")]
		[XmlArrayItem("crowd_rule_info")]
		public List<CrowdRuleInfo> Rulelist
		{
			get;
			set;
		}
	}
}
