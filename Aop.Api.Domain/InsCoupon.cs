using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsCoupon : AopObject
	{
		[XmlElement("actual_coupon_value")]
		public string ActualCouponValue
		{
			get;
			set;
		}

		[XmlElement("actual_discount_cash")]
		public long ActualDiscountCash
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
	}
}
