using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeBatchRefundQueryModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
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
