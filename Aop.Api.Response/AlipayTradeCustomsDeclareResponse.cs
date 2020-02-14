using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeCustomsDeclareResponse : AopResponse
	{
		[XmlElement("alipay_declare_no")]
		public string AlipayDeclareNo
		{
			get;
			set;
		}

		[XmlElement("identity_check")]
		public string IdentityCheck
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
