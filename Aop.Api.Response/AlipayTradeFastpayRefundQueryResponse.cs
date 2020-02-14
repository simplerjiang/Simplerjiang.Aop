using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeFastpayRefundQueryResponse : AopResponse
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("industry_sepc_detail")]
		public string IndustrySepcDetail
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
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

		[XmlElement("refund_amount")]
		public string RefundAmount
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

		[XmlArray("refund_royaltys")]
		[XmlArrayItem("refund_royalty_result")]
		public List<RefundRoyaltyResult> RefundRoyaltys
		{
			get;
			set;
		}

		[XmlElement("refund_status")]
		public string RefundStatus
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
	}
}
