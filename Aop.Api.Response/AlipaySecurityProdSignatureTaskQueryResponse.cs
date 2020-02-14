using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdSignatureTaskQueryResponse : AopResponse
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlArray("task_list")]
		[XmlArrayItem("sign_task_file_result")]
		public List<SignTaskFileResult> TaskList
		{
			get;
			set;
		}
	}
}
