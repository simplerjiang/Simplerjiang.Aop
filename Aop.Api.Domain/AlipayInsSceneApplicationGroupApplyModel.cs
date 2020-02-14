using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneApplicationGroupApplyModel : AopObject
	{
		[XmlElement("addressee")]
		public InsAddressee Addressee
		{
			get;
			set;
		}

		[XmlElement("applicant")]
		public InsPerson Applicant
		{
			get;
			set;
		}

		[XmlArray("applications")]
		[XmlArrayItem("ins_application")]
		public List<InsApplication> Applications
		{
			get;
			set;
		}

		[XmlElement("bill_title")]
		public string BillTitle
		{
			get;
			set;
		}

		[XmlArray("coupons")]
		[XmlArrayItem("ins_coupon")]
		public List<InsCoupon> Coupons
		{
			get;
			set;
		}

		[XmlElement("discount_id")]
		public string DiscountId
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

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("quote_biz_id")]
		public string QuoteBizId
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}
	}
}
