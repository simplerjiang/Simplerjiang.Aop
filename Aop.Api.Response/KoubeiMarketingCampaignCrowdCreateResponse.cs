using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignCrowdCreateResponse : AopResponse
	{
		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}
	}
}
