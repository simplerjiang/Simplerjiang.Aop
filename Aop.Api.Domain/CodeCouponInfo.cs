using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CodeCouponInfo : AopObject
	{
		[XmlElement("taken_time")]
		public string TakenTime
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}

		[XmlElement("voucher_amt")]
		public string VoucherAmt
		{
			get;
			set;
		}
	}
}
