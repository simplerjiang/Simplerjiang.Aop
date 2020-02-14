using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentBudgetInfo : AopObject
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
	}
}
