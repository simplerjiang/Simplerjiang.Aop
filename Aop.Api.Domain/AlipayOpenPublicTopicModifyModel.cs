using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicTopicModifyModel : AopObject
	{
		[XmlElement("img_url")]
		public string ImgUrl
		{
			get;
			set;
		}

		[XmlElement("link_type")]
		public string LinkType
		{
			get;
			set;
		}

		[XmlElement("link_url")]
		public string LinkUrl
		{
			get;
			set;
		}

		[XmlElement("sub_title")]
		public string SubTitle
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("topic_id")]
		public string TopicId
		{
			get;
			set;
		}

		[XmlElement("topic_items")]
		public TopicItem TopicItems
		{
			get;
			set;
		}
	}
}
