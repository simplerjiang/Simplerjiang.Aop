using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignPrizeAmountQueryResponse : AopResponse
	{
		[XmlElement("remain_amount")]
		public string RemainAmount
		{
			get;
			set;
		}
	}
}
