using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicTopicCreateModel : AopObject
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

		[XmlArray("topic_items")]
		[XmlArrayItem("topic_item")]
		public List<TopicItem> TopicItems
		{
			get;
			set;
		}
	}
}
