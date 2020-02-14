using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeItemorderRefundResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("real_refund_amount")]
		public string RealRefundAmount
		{
			get;
			set;
		}
	}
}
