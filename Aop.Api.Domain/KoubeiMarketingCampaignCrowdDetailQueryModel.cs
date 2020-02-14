using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignCrowdDetailQueryModel : AopObject
	{
		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}
	}
}
