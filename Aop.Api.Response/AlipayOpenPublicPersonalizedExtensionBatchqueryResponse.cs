using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AopResponse
	{
		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlArray("extensions")]
		[XmlArrayItem("query_extension")]
		public List<QueryExtension> Extensions
		{
			get;
			set;
		}
	}
}
