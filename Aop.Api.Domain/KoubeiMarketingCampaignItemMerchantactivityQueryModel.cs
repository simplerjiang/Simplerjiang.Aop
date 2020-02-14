using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignItemMerchantactivityQueryModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("external_unique_id")]
		public string ExternalUniqueId
		{
			get;
			set;
		}
	}
}
