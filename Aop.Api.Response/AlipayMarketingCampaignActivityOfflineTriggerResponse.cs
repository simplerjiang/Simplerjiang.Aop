using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignActivityOfflineTriggerResponse : AopResponse
	{
		[XmlElement("out_prize_id")]
		public string OutPrizeId
		{
			get;
			set;
		}
	}
}
