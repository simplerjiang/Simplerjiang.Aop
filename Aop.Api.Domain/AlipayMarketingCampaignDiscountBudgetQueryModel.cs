using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignDiscountBudgetQueryModel : AopObject
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}
	}
}
