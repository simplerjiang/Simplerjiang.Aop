using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignCrowdDetailQueryResponse : AopResponse
	{
		[XmlElement("crowd_group_info")]
		public string CrowdGroupInfo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
