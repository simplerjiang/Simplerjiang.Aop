using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosDiscountDetail : AopObject
	{
		[XmlElement("discount_name")]
		public string DiscountName
		{
			get;
			set;
		}

		[XmlElement("discount_type")]
		public string DiscountType
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

		[XmlElement("mrt_discount")]
		public string MrtDiscount
		{
			get;
			set;
		}

		[XmlElement("rt_discount")]
		public string RtDiscount
		{
			get;
			set;
		}
	}
}
