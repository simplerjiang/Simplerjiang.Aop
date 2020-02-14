using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsMarketingCampaignQueryResponse : AopResponse
	{
		[XmlElement("mkt_campaign")]
		public InsMktCampaignDTO MktCampaign
		{
			get;
			set;
		}
	}
}
