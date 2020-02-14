using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignDiscountWhitelistQueryModel : AopObject
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}
	}
}
