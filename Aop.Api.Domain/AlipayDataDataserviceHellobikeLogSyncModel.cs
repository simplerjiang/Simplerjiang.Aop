using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceHellobikeLogSyncModel : AopObject
	{
		[XmlElement("action_type")]
		public string ActionType
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("pay_price_cent")]
		public long PayPriceCent
		{
			get;
			set;
		}

		[XmlElement("pay_tool")]
		public string PayTool
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
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
