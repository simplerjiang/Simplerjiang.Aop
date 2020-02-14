using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetPointBudgetQueryResponse : AopResponse
	{
		[XmlElement("budget_amount")]
		public long BudgetAmount
		{
			get;
			set;
		}
	}
}
