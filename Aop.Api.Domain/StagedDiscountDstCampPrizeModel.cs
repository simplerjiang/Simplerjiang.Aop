using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class StagedDiscountDstCampPrizeModel : AopObject
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}

		[XmlArray("discount_rate_model_list")]
		[XmlArrayItem("discount_rate_model")]
		public List<DiscountRateModel> DiscountRateModelList
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
