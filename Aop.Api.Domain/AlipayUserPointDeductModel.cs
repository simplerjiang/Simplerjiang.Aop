using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserPointDeductModel : AopObject
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

		[XmlElement("prod_title")]
		public string ProdTitle
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
	}
}
