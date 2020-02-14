using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMemberCouponQuerylistResponse : AopResponse
	{
		[XmlArray("coupon_list")]
		[XmlArrayItem("coupon")]
		public List<Coupon> CouponList
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("list_size")]
		public string ListSize
		{
			get;
			set;
		}

		[XmlElement("success_code")]
		public string SuccessCode
		{
			get;
			set;
		}

		[XmlElement("total_num")]
		public string TotalNum
		{
			get;
			set;
		}
	}
}
