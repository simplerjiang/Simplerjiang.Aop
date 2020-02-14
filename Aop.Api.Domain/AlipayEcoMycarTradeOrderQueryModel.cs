using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarTradeOrderQueryModel : AopObject
	{
		[XmlElement("biz_trade_no")]
		public string BizTradeNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_trade_no")]
		public string OutBizTradeNo
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
