using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeOrderSettleResponse : AopResponse
	{
		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
