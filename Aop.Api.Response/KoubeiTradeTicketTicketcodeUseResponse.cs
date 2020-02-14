using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeTicketTicketcodeUseResponse : AopResponse
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("buyer_pay_amount")]
		public string BuyerPayAmount
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

		[XmlElement("discount_amount")]
		public string DiscountAmount
		{
			get;
			set;
		}

		[XmlElement("invoice_amount")]
		public string InvoiceAmount
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

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("koubei_subsidy_amount")]
		public string KoubeiSubsidyAmount
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("receipt_amount")]
		public string ReceiptAmount
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

		[XmlElement("ticket_code")]
		public string TicketCode
		{
			get;
			set;
		}

		[XmlElement("ticket_trans_id")]
		public string TicketTransId
		{
			get;
			set;
		}

		[XmlElement("use_date")]
		public string UseDate
		{
			get;
			set;
		}

		[XmlElement("use_shop_id")]
		public string UseShopId
		{
			get;
			set;
		}

		[XmlElement("use_shop_name")]
		public string UseShopName
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
