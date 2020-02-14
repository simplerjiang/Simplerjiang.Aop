using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignCrowdCountModel : AopObject
	{
		[XmlElement("conditions")]
		public string Conditions
		{
			get;
			set;
		}

		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}

		[XmlElement("dimensions")]
		public string Dimensions
		{
			get;
			set;
		}
	}
}
