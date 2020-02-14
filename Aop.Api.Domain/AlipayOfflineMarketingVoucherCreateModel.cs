using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketingVoucherCreateModel : AopObject
	{
		[XmlElement("budget_info")]
		public BudgetInfo BudgetInfo
		{
			get;
			set;
		}

		[XmlElement("code_inventory_id")]
		public string CodeInventoryId
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("get_rule")]
		public GetRuleInfo GetRule
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

		[XmlElement("voucher_info")]
		public VoucherInfo VoucherInfo
		{
			get;
			set;
		}
	}
}
