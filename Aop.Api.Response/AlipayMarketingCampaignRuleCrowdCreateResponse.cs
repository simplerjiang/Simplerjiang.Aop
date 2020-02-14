using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleCrowdCreateResponse : AopResponse
	{
		[XmlElement("ruleid")]
		public string Ruleid
		{
			get;
			set;
		}
	}
}
