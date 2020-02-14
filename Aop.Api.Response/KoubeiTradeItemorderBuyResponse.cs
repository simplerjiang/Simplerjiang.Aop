using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeItemorderBuyResponse : AopResponse
	{
		[XmlElement("cashier_order_id")]
		public string CashierOrderId
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

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
