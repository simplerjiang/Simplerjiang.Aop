using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingToolMallPointsSyncModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("json_content")]
		public string JsonContent
		{
			get;
			set;
		}

		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
		{
			get;
			set;
		}

		[XmlElement("out_biz_id")]
		public string OutBizId
		{
			get;
			set;
		}

		[XmlElement("state")]
		public string State
		{
			get;
			set;
		}

		[XmlElement("trade_id")]
		public string TradeId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
