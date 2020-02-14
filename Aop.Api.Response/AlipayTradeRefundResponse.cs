using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeRefundResponse : AopResponse
	{
		[XmlElement("buyer_logon_id")]
		public string BuyerLogonId
		{
			get;
			set;
		}

		[XmlElement("buyer_user_id")]
		public string BuyerUserId
		{
			get;
			set;
		}

		[XmlElement("fund_change")]
		public string FundChange
		{
			get;
			set;
		}

		[XmlElement("gmt_refund_pay")]
		public string GmtRefundPay
		{
			get;
			set;
		}

		[XmlElement("open_id")]
		public string OpenId
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("present_refund_buyer_amount")]
		public string PresentRefundBuyerAmount
		{
			get;
			set;
		}

		[XmlElement("present_refund_discount_amount")]
		public string PresentRefundDiscountAmount
		{
			get;
			set;
		}

		[XmlElement("present_refund_mdiscount_amount")]
		public string PresentRefundMdiscountAmount
		{
			get;
			set;
		}

		[XmlElement("refund_currency")]
		public string RefundCurrency
		{
			get;
			set;
		}

		[XmlArray("refund_detail_item_list")]
		[XmlArrayItem("trade_fund_bill")]
		public List<TradeFundBill> RefundDetailItemList
		{
			get;
			set;
		}

		[XmlElement("refund_fee")]
		public string RefundFee
		{
			get;
			set;
		}

		[XmlElement("send_back_fee")]
		public string SendBackFee
		{
			get;
			set;
		}

		[XmlElement("store_name")]
		public string StoreName
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
