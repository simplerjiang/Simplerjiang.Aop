using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}
	}
}
