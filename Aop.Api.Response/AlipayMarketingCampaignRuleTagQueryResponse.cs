using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleTagQueryResponse : AopResponse
	{
		[XmlElement("customtagjson")]
		public string Customtagjson
		{
			get;
			set;
		}

		[XmlElement("scenetagjson")]
		public string Scenetagjson
		{
			get;
			set;
		}
	}
}
