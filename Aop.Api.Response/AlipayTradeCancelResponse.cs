using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeCancelResponse : AopResponse
	{
		[XmlElement("action")]
		public string Action
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

		[XmlElement("retry_flag")]
		public string RetryFlag
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
