using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketingVoucherModifyModel : AopObject
	{
		[XmlElement("budget_info")]
		public BudgetInfo BudgetInfo
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

		[XmlElement("get_count_limit")]
		public PeriodInfo GetCountLimit
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
		public VoucherModifyInfo VoucherInfo
		{
			get;
			set;
		}
	}
}
