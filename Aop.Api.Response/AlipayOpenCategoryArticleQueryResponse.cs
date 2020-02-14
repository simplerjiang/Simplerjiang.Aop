using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenCategoryArticleQueryResponse : AopResponse
	{
		[XmlArray("articles")]
		[XmlArrayItem("life_recommend_articles")]
		public List<LifeRecommendArticles> Articles
		{
			get;
			set;
		}
	}
}
