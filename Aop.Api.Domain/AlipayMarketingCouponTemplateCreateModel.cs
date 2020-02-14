using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCouponTemplateCreateModel : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("extension_info")]
		public string ExtensionInfo
		{
			get;
			set;
		}

		[XmlElement("floor_amount")]
		public string FloorAmount
		{
			get;
			set;
		}

		[XmlElement("fund_account")]
		public string FundAccount
		{
			get;
			set;
		}

		[XmlElement("notify_uri")]
		public string NotifyUri
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

		[XmlElement("redirect_uri")]
		public string RedirectUri
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

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("voucher_description")]
		public string VoucherDescription
		{
			get;
			set;
		}

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}

		[XmlElement("voucher_use_scene")]
		public string VoucherUseScene
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
