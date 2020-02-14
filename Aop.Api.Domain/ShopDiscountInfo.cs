using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopDiscountInfo : AopObject
	{
		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("is_all")]
		public string IsAll
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("promo_sub_type")]
		public string PromoSubType
		{
			get;
			set;
		}

		[XmlElement("promotion_type")]
		public string PromotionType
		{
			get;
			set;
		}

		[XmlElement("purchase_mode")]
		public string PurchaseMode
		{
			get;
			set;
		}

		[XmlElement("sales_quantity")]
		public string SalesQuantity
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
	}
}
