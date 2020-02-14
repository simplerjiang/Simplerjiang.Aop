using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicGroupBatchqueryResponse : AopResponse
	{
		[XmlArray("groups")]
		[XmlArrayItem("query_group")]
		public List<QueryGroup> Groups
		{
			get;
			set;
		}
	}
}
