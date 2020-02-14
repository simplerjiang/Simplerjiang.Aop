using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}
	}
}
