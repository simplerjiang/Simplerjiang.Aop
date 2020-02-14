using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDatabizCorePaymentAbilityUpdateResponse : AopResponse
	{
		[XmlElement("payment_ability_postback_response")]
		public PaymentAbilityPostbackResponse PaymentAbilityPostbackResponse
		{
			get;
			set;
		}
	}
}
