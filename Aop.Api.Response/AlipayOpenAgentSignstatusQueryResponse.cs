using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAgentSignstatusQueryResponse : AopResponse
	{
		[XmlArray("sign_status_list")]
		[XmlArrayItem("product_sign_status_info")]
		public List<ProductSignStatusInfo> SignStatusList
		{
			get;
			set;
		}
	}
}
