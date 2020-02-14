using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbOrderVoucherModel : AopObject
	{
		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("funds_voucher_no")]
		public string FundsVoucherNo
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

		[XmlElement("refund_reason")]
		public string RefundReason
		{
			get;
			set;
		}

		[XmlElement("refund_type")]
		public string RefundType
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}

		[XmlElement("ticket_effect_count")]
		public string TicketEffectCount
		{
			get;
			set;
		}

		[XmlElement("ticket_refunded_count")]
		public string TicketRefundedCount
		{
			get;
			set;
		}

		[XmlElement("ticket_used_count")]
		public string TicketUsedCount
		{
			get;
			set;
		}

		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
