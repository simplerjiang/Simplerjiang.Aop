using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignDiscountBudgetCreateModel : AopObject
	{
		[XmlElement("biz_from")]
		public string BizFrom
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("out_budget_no")]
		public string OutBudgetNo
		{
			get;
			set;
		}

		[XmlElement("publisher_logon_id")]
		public string PublisherLogonId
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
	}
}
