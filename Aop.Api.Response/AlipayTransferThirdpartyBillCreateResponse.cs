using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTransferThirdpartyBillCreateResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_type")]
		public string OrderType
		{
			get;
			set;
		}

		[XmlElement("payment_id")]
		public string PaymentId
		{
			get;
			set;
		}
	}
}
