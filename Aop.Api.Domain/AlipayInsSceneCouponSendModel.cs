using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneCouponSendModel : AopObject
	{
		[XmlElement("channel_user_id")]
		public string ChannelUserId
		{
			get;
			set;
		}

		[XmlElement("channel_user_source")]
		public string ChannelUserSource
		{
			get;
			set;
		}

		[XmlElement("dimension_id")]
		public string DimensionId
		{
			get;
			set;
		}

		[XmlElement("dimension_type")]
		public string DimensionType
		{
			get;
			set;
		}

		[XmlElement("market_type")]
		public string MarketType
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

		[XmlElement("service_scenario")]
		public string ServiceScenario
		{
			get;
			set;
		}
	}
}
