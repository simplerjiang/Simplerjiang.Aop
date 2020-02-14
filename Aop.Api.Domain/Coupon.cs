using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Coupon : AopObject
	{
		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("coupon_no")]
		public string CouponNo
		{
			get;
			set;
		}

		[XmlElement("deduct_amount")]
		public string DeductAmount
		{
			get;
			set;
		}

		[XmlElement("gmt_active")]
		public string GmtActive
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_expired")]
		public string GmtExpired
		{
			get;
			set;
		}

		[XmlElement("instructions")]
		public string Instructions
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("merchant_uniq_id")]
		public string MerchantUniqId
		{
			get;
			set;
		}

		[XmlElement("multi_use_flag")]
		public string MultiUseFlag
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("refund_flag")]
		public string RefundFlag
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("template_no")]
		public string TemplateNo
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
