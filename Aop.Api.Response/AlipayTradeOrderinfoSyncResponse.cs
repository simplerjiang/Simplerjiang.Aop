using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeOrderinfoSyncResponse : AopResponse
	{
		[XmlElement("buyer_user_id")]
		public string BuyerUserId
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

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
