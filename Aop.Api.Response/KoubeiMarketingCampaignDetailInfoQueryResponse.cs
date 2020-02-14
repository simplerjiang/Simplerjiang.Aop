using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignDetailInfoQueryResponse : AopResponse
	{
		[XmlElement("limit_shops")]
		public string LimitShops
		{
			get;
			set;
		}
	}
}
