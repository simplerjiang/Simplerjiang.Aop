using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppBillRefundModel : AopObject
	{
		[XmlElement("alipay_bill_no")]
		public string AlipayBillNo
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlElement("refund_from")]
		public string RefundFrom
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}
	}
}
