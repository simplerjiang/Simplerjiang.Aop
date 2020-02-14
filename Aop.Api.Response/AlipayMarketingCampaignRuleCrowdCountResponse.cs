using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleCrowdCountResponse : AopResponse
	{
		[XmlElement("crowdcount")]
		public string Crowdcount
		{
			get;
			set;
		}
	}
}
