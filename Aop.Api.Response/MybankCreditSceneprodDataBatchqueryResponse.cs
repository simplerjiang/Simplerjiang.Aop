using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodDataBatchqueryResponse : AopResponse
	{
		[XmlArray("result_data")]
		[XmlArrayItem("scene_prod_data_query_result_detail")]
		public List<SceneProdDataQueryResultDetail> ResultData
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public string Retry
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}
	}
}
