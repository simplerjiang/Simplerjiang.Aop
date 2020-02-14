using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsUnderwriteMutualPolicyBatchqueryResponse : AopResponse
	{
		[XmlElement("plan_no")]
		public string PlanNo
		{
			get;
			set;
		}

		[XmlArray("policy_nos")]
		[XmlArrayItem("string")]
		public List<string> PolicyNos
		{
			get;
			set;
		}
	}
}
