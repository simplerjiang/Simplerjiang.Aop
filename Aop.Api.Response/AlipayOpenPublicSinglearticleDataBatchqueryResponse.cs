using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicSinglearticleDataBatchqueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("single_article_analysis_data")]
		public List<SingleArticleAnalysisData> DataList
		{
			get;
			set;
		}
	}
}
