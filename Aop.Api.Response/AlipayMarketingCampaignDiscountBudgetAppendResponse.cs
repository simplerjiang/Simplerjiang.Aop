using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignDiscountBudgetAppendResponse : AopResponse
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}
	}
}
