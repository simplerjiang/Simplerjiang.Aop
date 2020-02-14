using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarTradeOrderQueryResponse : AopResponse
	{
		[XmlElement("biz_trade_no")]
		public string BizTradeNo
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

		[XmlElement("buyer_logon_id")]
		public string BuyerLogonId
		{
			get;
			set;
		}

		[XmlElement("gmt_closed")]
		public string GmtClosed
		{
			get;
			set;
		}

		[XmlElement("gmt_created")]
		public string GmtCreated
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

		[XmlElement("gmt_payment_success")]
		public string GmtPaymentSuccess
		{
			get;
			set;
		}

		[XmlElement("gmt_refund")]
		public string GmtRefund
		{
			get;
			set;
		}

		[XmlElement("gmt_refund_success")]
		public string GmtRefundSuccess
		{
			get;
			set;
		}

		[XmlElement("gmt_updated")]
		public string GmtUpdated
		{
			get;
			set;
		}

		[XmlElement("out_biz_trade_no")]
		public string OutBizTradeNo
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

		[XmlElement("shop_id")]
		public long ShopId
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

		[XmlElement("summary")]
		public string Summary
		{
			get;
			set;
		}

		[XmlElement("total_fee")]
		public string TotalFee
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

		[XmlElement("trade_status")]
		public long TradeStatus
		{
			get;
			set;
		}

		[XmlElement("trade_type")]
		public long TradeType
		{
			get;
			set;
		}
	}
}
