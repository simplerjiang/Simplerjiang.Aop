using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserFinanceinfoShareResponse : AopResponse
	{
		[XmlArray("credit_card_list")]
		[XmlArrayItem("alipay_user_credit_card")]
		public List<AlipayUserCreditCard> CreditCardList
		{
			get;
			set;
		}
	}
}
