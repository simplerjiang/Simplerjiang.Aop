using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RefundDetail : AopObject
	{
		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlElement("refund_memo")]
		public string RefundMemo
		{
			get;
			set;
		}

		[XmlArray("refund_royaltys")]
		[XmlArrayItem("refund_royalty_info")]
		public List<RefundRoyaltyInfo> RefundRoyaltys
		{
			get;
			set;
		}

		[XmlElement("refund_suppl_amount")]
		public string RefundSupplAmount
		{
			get;
			set;
		}

		[XmlElement("refund_suppl_memo")]
		public string RefundSupplMemo
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
