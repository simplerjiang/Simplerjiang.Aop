using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolPromocommoptOpeneventSendModel : AopObject
	{
		[XmlElement("biz_time")]
		public string BizTime
		{
			get;
			set;
		}

		[XmlElement("event_code")]
		public string EventCode
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public long Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public long Longitude
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
