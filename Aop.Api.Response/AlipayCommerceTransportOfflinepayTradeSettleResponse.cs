using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceTransportOfflinepayTradeSettleResponse : AopResponse
	{
		[XmlArray("result_list")]
		[XmlArrayItem("alipay_offline_trade_result")]
		public List<AlipayOfflineTradeResult> ResultList
		{
			get;
			set;
		}
	}
}
