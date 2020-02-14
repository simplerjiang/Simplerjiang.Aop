using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignPrizeAmountQueryModel : AopObject
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
