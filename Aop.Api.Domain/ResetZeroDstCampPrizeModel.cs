using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ResetZeroDstCampPrizeModel : AopObject
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

		[XmlElement("reset_zero_amt")]
		public string ResetZeroAmt
		{
			get;
			set;
		}
	}
}
