using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenDataItemRecommendBatchqueryResponse : AopResponse
	{
		[XmlArray("result_obj")]
		[XmlArrayItem("rec_result_info")]
		public List<RecResultInfo> ResultObj
		{
			get;
			set;
		}
	}
}
