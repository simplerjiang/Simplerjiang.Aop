using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCashlessvoucherTemplateModifyModel : AopObject
	{
		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("publish_end_time")]
		public string PublishEndTime
		{
			get;
			set;
		}

		[XmlElement("rule_conf")]
		public string RuleConf
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
