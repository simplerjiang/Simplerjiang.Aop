using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarOrderRefundModel : AopObject
	{
		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("req_no")]
		public string ReqNo
		{
			get;
			set;
		}
	}
}
