using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktCouponConfigDTO : AopObject
	{
		[XmlElement("coupon_conf_id")]
		public string CouponConfId
		{
			get;
			set;
		}

		[XmlElement("coupon_type")]
		public string CouponType
		{
			get;
			set;
		}

		[XmlElement("coupon_value")]
		public string CouponValue
		{
			get;
			set;
		}

		[XmlElement("use_end_time")]
		public string UseEndTime
		{
			get;
			set;
		}

		[XmlElement("use_rule")]
		public string UseRule
		{
			get;
			set;
		}

		[XmlElement("use_start_time")]
		public string UseStartTime
		{
			get;
			set;
		}
	}
}
