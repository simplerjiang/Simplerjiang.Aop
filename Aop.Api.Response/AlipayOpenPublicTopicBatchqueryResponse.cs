using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicTopicBatchqueryResponse : AopResponse
	{
		[XmlArray("topic_list")]
		[XmlArrayItem("topic")]
		public List<Topic> TopicList
		{
			get;
			set;
		}
	}
}
