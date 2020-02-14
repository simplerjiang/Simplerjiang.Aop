using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppBillRefundResponse : AopResponse
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

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
