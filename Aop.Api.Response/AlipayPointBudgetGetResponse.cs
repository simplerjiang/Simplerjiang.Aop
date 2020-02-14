using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPointBudgetGetResponse : AopResponse
	{
		[XmlElement("budget_amount")]
		public long BudgetAmount
		{
			get;
			set;
		}
	}
}
