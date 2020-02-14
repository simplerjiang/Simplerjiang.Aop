using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CraftsmanShopRelationOpenModel : AopObject
	{
		[XmlElement("recommend_weight")]
		public long RecommendWeight
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
