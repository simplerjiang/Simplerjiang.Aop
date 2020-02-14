using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeCloseModel : AopObject
	{
		[XmlElement("operator_id")]
		public string OperatorId
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
