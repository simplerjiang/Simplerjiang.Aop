using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcardEduBalanceGetResponse : AopResponse
	{
		[XmlArray("balance")]
		[XmlArrayItem("edu_one_card_balance_query_result")]
		public List<EduOneCardBalanceQueryResult> Balance
		{
			get;
			set;
		}
	}
}
