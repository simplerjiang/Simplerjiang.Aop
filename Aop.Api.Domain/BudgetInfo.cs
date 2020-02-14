using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BudgetInfo : AopObject
	{
		[XmlElement("budget_total")]
		public string BudgetTotal
		{
			get;
			set;
		}

		[XmlElement("budget_type")]
		public string BudgetType
		{
			get;
			set;
		}

		[XmlElement("sub_budget_dimension")]
		public string SubBudgetDimension
		{
			get;
			set;
		}

		[XmlElement("sub_value")]
		public string SubValue
		{
			get;
			set;
		}
	}
}
