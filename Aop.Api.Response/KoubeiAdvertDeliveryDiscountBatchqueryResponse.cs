using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDeliveryDiscountBatchqueryResponse : AopResponse
	{
		[XmlArray("discounts")]
		[XmlArrayItem("discount_info")]
		public List<DiscountInfo> Discounts
		{
			get;
			set;
		}

		[XmlElement("purchase_datas")]
		public KbAdvertIdentifyResponse PurchaseDatas
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
