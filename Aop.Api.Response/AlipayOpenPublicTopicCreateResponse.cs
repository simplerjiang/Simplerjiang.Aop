using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicTopicCreateResponse : AopResponse
	{
		[XmlElement("topic_id")]
		public string TopicId
		{
			get;
			set;
		}
	}
}
