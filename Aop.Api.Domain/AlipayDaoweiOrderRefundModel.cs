using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiOrderRefundModel : AopObject
	{
		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("out_refund_id")]
		public string OutRefundId
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

		[XmlArray("refund_details")]
		[XmlArrayItem("order_refund_info")]
		public List<OrderRefundInfo> RefundDetails
		{
			get;
			set;
		}
	}
}
