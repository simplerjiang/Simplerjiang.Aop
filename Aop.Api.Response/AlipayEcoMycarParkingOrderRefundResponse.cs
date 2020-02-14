using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingOrderRefundResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("refund_no")]
		public string RefundNo
		{
			get;
			set;
		}
	}
}
