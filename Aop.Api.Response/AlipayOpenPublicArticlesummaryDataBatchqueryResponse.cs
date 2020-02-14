using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicArticlesummaryDataBatchqueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("article_summary_analysis_data")]
		public List<ArticleSummaryAnalysisData> DataList
		{
			get;
			set;
		}
	}
}
