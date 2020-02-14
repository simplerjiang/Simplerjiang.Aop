using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtBillingQueryResponse : AopResponse
	{
		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}
	}
}
