using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsUnderwriteUserPolicyQueryResponse : AopResponse
	{
		[XmlArray("policys")]
		[XmlArrayItem("ins_policy")]
		public List<InsPolicy> Policys
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}
