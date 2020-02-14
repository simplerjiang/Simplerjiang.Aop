using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceShoppingmallrecShopQueryResponse : AopResponse
	{
		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlArray("shop_recommend_list")]
		[XmlArrayItem("shop_rec")]
		public List<ShopRec> ShopRecommendList
		{
			get;
			set;
		}
	}
}
