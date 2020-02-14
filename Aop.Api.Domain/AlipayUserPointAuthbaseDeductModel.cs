using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserPointAuthbaseDeductModel : AopObject
	{
		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}

		[XmlElement("biz_date")]
		public string BizDate
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
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

		[XmlElement("sub_biz_type")]
		public string SubBizType
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
