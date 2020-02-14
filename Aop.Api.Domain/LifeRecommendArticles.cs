using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LifeRecommendArticles : AopObject
	{
		[XmlElement("article_id")]
		public string ArticleId
		{
			get;
			set;
		}

		[XmlElement("article_image")]
		public string ArticleImage
		{
			get;
			set;
		}

		[XmlElement("article_link")]
		public string ArticleLink
		{
			get;
			set;
		}

		[XmlElement("article_read_cnt")]
		public string ArticleReadCnt
		{
			get;
			set;
		}

		[XmlElement("article_source")]
		public string ArticleSource
		{
			get;
			set;
		}

		[XmlElement("article_title")]
		public string ArticleTitle
		{
			get;
			set;
		}
	}
}
