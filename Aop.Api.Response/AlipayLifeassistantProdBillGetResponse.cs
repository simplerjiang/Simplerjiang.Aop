using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayLifeassistantProdBillGetResponse : AopResponse
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_item")]
		public string OrderItem
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public string PayType
		{
			get;
			set;
		}

		[XmlElement("payee")]
		public string Payee
		{
			get;
			set;
		}

		[XmlElement("trade_type")]
		public string TradeType
		{
			get;
			set;
		}
	}
}
