using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdSignatureTaskApplyResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlArray("task_list")]
		[XmlArrayItem("sign_task_result")]
		public List<SignTaskResult> TaskList
		{
			get;
			set;
		}
	}
}
