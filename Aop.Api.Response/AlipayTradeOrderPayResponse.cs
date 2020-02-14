using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeOrderPayResponse : AopResponse
	{
		[XmlElement("out_trade_no")]
		public string OutTradeNo
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
