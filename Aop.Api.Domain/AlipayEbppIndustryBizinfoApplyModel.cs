using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppIndustryBizinfoApplyModel : AopObject
	{
		[XmlElement("ability_code")]
		public string AbilityCode
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("biz_inst")]
		public string BizInst
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

		[XmlElement("out_apply_no")]
		public string OutApplyNo
		{
			get;
			set;
		}

		[XmlElement("request_context")]
		public string RequestContext
		{
			get;
			set;
		}
	}
}
