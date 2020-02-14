using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeRefundModel : AopObject
	{
		[XmlArray("goods_detail")]
		[XmlArrayItem("goods_detail")]
		public List<GoodsDetail> GoodsDetail
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
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

		[XmlElement("refund_amount")]
		public string RefundAmount
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

		[XmlElement("refund_reason")]
		public string RefundReason
		{
			get;
			set;
		}

		[XmlArray("refund_royalty_parameters")]
		[XmlArrayItem("open_api_royalty_detail_info_pojo")]
		public List<OpenApiRoyaltyDetailInfoPojo> RefundRoyaltyParameters
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

		[XmlElement("terminal_id")]
		public string TerminalId
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
