using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCashvoucherTemplateModifyModel : AopObject
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

		[XmlElement("publish_start_time")]
		public string PublishStartTime
		{
			get;
			set;
		}

		[XmlElement("slogan")]
		public string Slogan
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

		[XmlElement("voucher_valid_period")]
		public string VoucherValidPeriod
		{
			get;
			set;
		}
	}
}
