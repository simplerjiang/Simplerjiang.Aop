using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneContent : AopObject
	{
		[XmlElement("article_classify")]
		public long ArticleClassify
		{
			get;
			set;
		}

		[XmlElement("author")]
		public string Author
		{
			get;
			set;
		}

		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlArray("image_list")]
		[XmlArrayItem("string")]
		public List<string> ImageList
		{
			get;
			set;
		}

		[XmlElement("public_id")]
		public string PublicId
		{
			get;
			set;
		}

		[XmlElement("public_name")]
		public string PublicName
		{
			get;
			set;
		}

		[XmlElement("scheme")]
		public string Scheme
		{
			get;
			set;
		}

		[XmlElement("scm")]
		public string Scm
		{
			get;
			set;
		}

		[XmlElement("summary")]
		public string Summary
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

		[XmlElement("total_praise_count")]
		public long TotalPraiseCount
		{
			get;
			set;
		}

		[XmlElement("total_reply_count")]
		public long TotalReplyCount
		{
			get;
			set;
		}

		[XmlElement("total_view_count")]
		public long TotalViewCount
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
