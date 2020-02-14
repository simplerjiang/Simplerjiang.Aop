using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OrderRefundInfo : AopObject
	{
		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlElement("service_order_no")]
		public string ServiceOrderNo
		{
			get;
			set;
		}
	}
}
