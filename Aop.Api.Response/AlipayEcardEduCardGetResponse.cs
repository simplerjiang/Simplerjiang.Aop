using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcardEduCardGetResponse : AopResponse
	{
		[XmlElement("first_deposit_flag")]
		public bool FirstDepositFlag
		{
			get;
			set;
		}

		[XmlArray("onecard")]
		[XmlArrayItem("edu_one_card_deposit_card_query_result")]
		public List<EduOneCardDepositCardQueryResult> Onecard
		{
			get;
			set;
		}
	}
}
