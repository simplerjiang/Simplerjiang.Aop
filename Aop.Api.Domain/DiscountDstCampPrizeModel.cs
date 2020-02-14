using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountDstCampPrizeModel : AopObject
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}

		[XmlElement("discount_rate")]
		public string DiscountRate
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("max_discount_amt")]
		public string MaxDiscountAmt
		{
			get;
			set;
		}
	}
}
