using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicContentPublishModel : AopObject
	{
		[XmlElement("action_url")]
		public string ActionUrl
		{
			get;
			set;
		}

		[XmlElement("article_id")]
		public string ArticleId
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("cover_img")]
		public string CoverImg
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("source")]
		public string Source
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
	}
}
