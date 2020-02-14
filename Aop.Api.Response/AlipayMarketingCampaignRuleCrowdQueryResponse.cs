using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignRuleCrowdQueryResponse : AopResponse
	{
		[XmlElement("scenetagjson")]
		public string Scenetagjson
		{
			get;
			set;
		}
	}
}
