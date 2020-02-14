using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeLoanrelationQueryResponse : AopResponse
	{
		[XmlElement("loan_relation_flag")]
		public bool LoanRelationFlag
		{
			get;
			set;
		}
	}
}
