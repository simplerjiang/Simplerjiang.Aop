using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicTopicDeleteModel : AopObject
	{
		[XmlElement("topic_id")]
		public string TopicId
		{
			get;
			set;
		}
	}
}
