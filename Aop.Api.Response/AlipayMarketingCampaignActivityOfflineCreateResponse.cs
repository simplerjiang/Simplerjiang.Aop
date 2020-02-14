using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignActivityOfflineCreateResponse : AopResponse
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("prize_id")]
		public string PrizeId
		{
			get;
			set;
		}
	}
}
