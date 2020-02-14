using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDiscountBudgetQueryResponse : AopResponse
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}

		[XmlElement("freeze_amount")]
		public string FreezeAmount
		{
			get;
			set;
		}

		[XmlElement("recycle_amount")]
		public string RecycleAmount
		{
			get;
			set;
		}

		[XmlElement("refund_amount")]
		public string RefundAmount
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

		[XmlElement("used_amount")]
		public string UsedAmount
		{
			get;
			set;
		}
	}
}
