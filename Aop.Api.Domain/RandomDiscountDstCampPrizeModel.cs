using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RandomDiscountDstCampPrizeModel : AopObject
	{
		[XmlElement("budget_id")]
		public string BudgetId
		{
			get;
			set;
		}

		[XmlArray("discount_random_model_list")]
		[XmlArrayItem("discount_random_model")]
		public List<DiscountRandomModel> DiscountRandomModelList
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

		[XmlElement("max_random_discount_rate")]
		public string MaxRandomDiscountRate
		{
			get;
			set;
		}
	}
}
