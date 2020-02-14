using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceTradeInfo : AopObject
	{
		[XmlElement("alipay_trade_no")]
		public string AlipayTradeNo
		{
			get;
			set;
		}

		[XmlElement("create_trade_date")]
		public string CreateTradeDate
		{
			get;
			set;
		}

		[XmlElement("einv_trade_id")]
		public string EinvTradeId
		{
			get;
			set;
		}

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlArray("invoice_content")]
		[XmlArrayItem("invoice_item_query_open_model")]
		public List<InvoiceItemQueryOpenModel> InvoiceContent
		{
			get;
			set;
		}

		[XmlElement("m_name")]
		public string MName
		{
			get;
			set;
		}

		[XmlElement("m_short_name")]
		public string MShortName
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
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

		[XmlElement("payment_trade_date")]
		public string PaymentTradeDate
		{
			get;
			set;
		}

		[XmlElement("real_amount")]
		public string RealAmount
		{
			get;
			set;
		}

		[XmlElement("sub_m_name")]
		public string SubMName
		{
			get;
			set;
		}

		[XmlElement("sub_m_short_name")]
		public string SubMShortName
		{
			get;
			set;
		}

		[XmlElement("trade_amount")]
		public string TradeAmount
		{
			get;
			set;
		}

		[XmlArray("trade_fund_list")]
		[XmlArrayItem("invoice_trade_fund_item")]
		public List<InvoiceTradeFundItem> TradeFundList
		{
			get;
			set;
		}

		[XmlArray("trade_goods_list")]
		[XmlArrayItem("invoice_trade_goods_item")]
		public List<InvoiceTradeGoodsItem> TradeGoodsList
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
