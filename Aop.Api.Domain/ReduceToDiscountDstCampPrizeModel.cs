using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReduceToDiscountDstCampPrizeModel : AopObject
	{
		[XmlElement("budget_id")]
		public string BudgetId
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

		[XmlElement("reduce_to_discount_rate")]
		public string ReduceToDiscountRate
		{
			get;
			set;
		}
	}
}
