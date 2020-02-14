using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodPolicyApplyResponse : AopResponse
	{
		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
		{
			get;
			set;
		}

		[XmlElement("quote_biz_id")]
		public string QuoteBizId
		{
			get;
			set;
		}

		[XmlArray("trade_infos")]
		[XmlArrayItem("ins_trade_info")]
		public List<InsTradeInfo> TradeInfos
		{
			get;
			set;
		}

		[XmlElement("zhi_link")]
		public string ZhiLink
		{
			get;
			set;
		}
	}
}
