using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCdpRecommendQueryResponse : AopResponse
	{
		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}

		[XmlElement("shop_info")]
		public string ShopInfo
		{
			get;
			set;
		}
	}
}
