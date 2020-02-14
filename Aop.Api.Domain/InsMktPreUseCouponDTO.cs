using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsMktPreUseCouponDTO : AopObject
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

		[XmlElement("pre_use")]
		public bool PreUse
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
		{
			get;
			set;
		}
	}
}
