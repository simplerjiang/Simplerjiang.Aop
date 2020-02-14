using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeOrderinfoSyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("order_biz_info")]
		public string OrderBizInfo
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
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
