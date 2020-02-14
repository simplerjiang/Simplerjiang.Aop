using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeItemBuyModel : AopObject
	{
		[XmlElement("buyer_phone_number")]
		public string BuyerPhoneNumber
		{
			get;
			set;
		}

		[XmlElement("buyer_user_name")]
		public string BuyerUserName
		{
			get;
			set;
		}

		[XmlElement("craftsman_id")]
		public string CraftsmanId
		{
			get;
			set;
		}

		[XmlElement("current_price")]
		public string CurrentPrice
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
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

		[XmlElement("original_price")]
		public string OriginalPrice
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("reserve_end_time")]
		public string ReserveEndTime
		{
			get;
			set;
		}

		[XmlElement("reserve_start_time")]
		public string ReserveStartTime
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
