using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingOrderRefundModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("out_refund_no")]
		public string OutRefundNo
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

		[XmlElement("refund_reason")]
		public string RefundReason
		{
			get;
			set;
		}
	}
}
