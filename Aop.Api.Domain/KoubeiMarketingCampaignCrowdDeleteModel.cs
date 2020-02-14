using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignCrowdDeleteModel : AopObject
	{
		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}
	}
}
