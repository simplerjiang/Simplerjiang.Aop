using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDatabizCorePaymentAbilityGetResponse : AopResponse
	{
		[XmlElement("payment_ability_query_response")]
		public PaymentAbilityQueryResponse PaymentAbilityQueryResponse
		{
			get;
			set;
		}
	}
}
