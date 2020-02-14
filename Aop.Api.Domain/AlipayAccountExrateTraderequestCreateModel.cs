using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountExrateTraderequestCreateModel : AopObject
	{
		[XmlElement("trade_request")]
		public TradeRequestVO TradeRequest
		{
			get;
			set;
		}
	}
}
