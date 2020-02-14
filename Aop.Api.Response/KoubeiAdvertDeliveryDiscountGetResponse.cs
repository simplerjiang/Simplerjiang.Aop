using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDeliveryDiscountGetResponse : AopResponse
	{
		[XmlElement("discounts")]
		public DiscountInfo Discounts
		{
			get;
			set;
		}

		[XmlElement("recommend_id")]
		public string RecommendId
		{
			get;
			set;
		}
	}
}
