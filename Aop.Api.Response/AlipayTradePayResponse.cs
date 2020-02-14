using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradePayResponse : AopResponse
	{
		[XmlElement("async_payment_mode")]
		public string AsyncPaymentMode
		{
			get;
			set;
		}

		[XmlElement("auth_trade_pay_mode")]
		public string AuthTradePayMode
		{
			get;
			set;
		}

		[XmlElement("business_params")]
		public string BusinessParams
		{
			get;
			set;
		}

		[XmlElement("buyer_logon_id")]
		public string BuyerLogonId
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

		[XmlElement("buyer_user_id")]
		public string BuyerUserId
		{
			get;
			set;
		}

		[XmlElement("buyer_user_type")]
		public string BuyerUserType
		{
			get;
			set;
		}

		[XmlElement("card_balance")]
		public string CardBalance
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

		[XmlElement("discount_goods_detail")]
		public string DiscountGoodsDetail
		{
			get;
			set;
		}

		[XmlArray("fund_bill_list")]
		[XmlArrayItem("trade_fund_bill")]
		public List<TradeFundBill> FundBillList
		{
			get;
			set;
		}

		[XmlElement("gmt_payment")]
		public string GmtPayment
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

		[XmlElement("mdiscount_amount")]
		public string MdiscountAmount
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

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("pay_currency")]
		public string PayCurrency
		{
			get;
			set;
		}

		[XmlElement("point_amount")]
		public string PointAmount
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

		[XmlElement("settle_amount")]
		public string SettleAmount
		{
			get;
			set;
		}

		[XmlElement("settle_currency")]
		public string SettleCurrency
		{
			get;
			set;
		}

		[XmlElement("settle_trans_rate")]
		public string SettleTransRate
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

		[XmlElement("total_amount")]
		public string TotalAmount
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

		[XmlElement("trans_currency")]
		public string TransCurrency
		{
			get;
			set;
		}

		[XmlElement("trans_pay_rate")]
		public string TransPayRate
		{
			get;
			set;
		}

		[XmlArray("voucher_detail_list")]
		[XmlArrayItem("voucher_detail")]
		public List<VoucherDetail> VoucherDetailList
		{
			get;
			set;
		}
	}
}
