using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignAssetDetailQueryResponse : AopResponse
	{
		[XmlElement("limit_shops")]
		public string LimitShops
		{
			get;
			set;
		}
	}
}
