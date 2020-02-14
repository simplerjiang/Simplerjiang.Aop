using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MemberPointsScene : AopObject
	{
		[XmlElement("exchange_info")]
		public PointsExchangeInfo ExchangeInfo
		{
			get;
			set;
		}

		[XmlElement("kb_trade_no")]
		public string KbTradeNo
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

		[XmlElement("modify_time")]
		public string ModifyTime
		{
			get;
			set;
		}

		[XmlElement("oper_type")]
		public string OperType
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("points_balance")]
		public long PointsBalance
		{
			get;
			set;
		}
	}
}
