using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoServiceCouponVerifyModel : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("coupon_id")]
		public string CouponId
		{
			get;
			set;
		}

		[XmlElement("event")]
		public string Event
		{
			get;
			set;
		}

		[XmlElement("event_date")]
		public string EventDate
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

		[XmlElement("sp_coupon_id")]
		public string SpCouponId
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
