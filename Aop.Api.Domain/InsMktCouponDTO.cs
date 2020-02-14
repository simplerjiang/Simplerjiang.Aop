using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktCouponDTO : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
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

		[XmlElement("recommend")]
		public bool Recommend
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
