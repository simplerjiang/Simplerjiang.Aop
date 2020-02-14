using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeBatchRefundQueryResponse : AopResponse
	{
		[XmlArray("result_details")]
		[XmlArrayItem("batch_refund_detail_result")]
		public List<BatchRefundDetailResult> ResultDetails
		{
			get;
			set;
		}
	}
}
