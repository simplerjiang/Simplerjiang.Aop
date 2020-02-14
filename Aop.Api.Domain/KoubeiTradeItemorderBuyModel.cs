using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeItemorderBuyModel : AopObject
	{
		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

		[XmlElement("buyer_id")]
		public string BuyerId
		{
			get;
			set;
		}

		[XmlArray("item_order_details")]
		[XmlArrayItem("item_order_detail")]
		public List<ItemOrderDetail> ItemOrderDetails
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("promo_params")]
		public string PromoParams
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

		[XmlElement("subject")]
		public string Subject
		{
			get;
			set;
		}

		[XmlElement("timeout")]
		public string Timeout
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
