using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleTagCreateResponse : AopResponse
	{
		[XmlElement("customertag")]
		public string Customertag
		{
			get;
			set;
		}
	}
}
