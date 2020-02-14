using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorDepositQueryResponse : AopResponse
	{
		[XmlArray("recharge_bills")]
		[XmlArrayItem("recharge_bill")]
		public List<RechargeBill> RechargeBills
		{
			get;
			set;
		}
	}
}
