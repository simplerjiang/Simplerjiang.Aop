using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditAutofinanceLoanPlanQueryResponse : AopResponse
	{
		[XmlElement("loanplan")]
		public string Loanplan
		{
			get;
			set;
		}
	}
}
