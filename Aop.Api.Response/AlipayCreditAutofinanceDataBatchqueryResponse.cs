using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditAutofinanceDataBatchqueryResponse : AopResponse
	{
		[XmlArray("result_data")]
		[XmlArrayItem("scene_data_query_result_detail")]
		public List<SceneDataQueryResultDetail> ResultData
		{
			get;
			set;
		}
	}
}
