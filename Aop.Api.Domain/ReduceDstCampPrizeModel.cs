using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ReduceDstCampPrizeModel : AopObject
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

		[XmlElement("reduce_amt_pre")]
		public string ReduceAmtPre
		{
			get;
			set;
		}

		[XmlElement("reduce_amt_suf")]
		public string ReduceAmtSuf
		{
			get;
			set;
		}
	}
}
