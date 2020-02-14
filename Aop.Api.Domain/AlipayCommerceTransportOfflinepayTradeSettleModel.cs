using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceTransportOfflinepayTradeSettleModel : AopObject
	{
		[XmlArray("trade_list")]
		[XmlArrayItem("alipay_offline_trade")]
		public List<AlipayOfflineTrade> TradeList
		{
			get;
			set;
		}
	}
}
