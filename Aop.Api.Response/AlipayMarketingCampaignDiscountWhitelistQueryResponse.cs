using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDiscountWhitelistQueryResponse : AopResponse
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("user_white_list")]
		public string UserWhiteList
		{
			get;
			set;
		}
	}
}
