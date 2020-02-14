using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradePrecreateResponse : AopResponse
	{
		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("qr_code")]
		public string QrCode
		{
			get;
			set;
		}
	}
}
