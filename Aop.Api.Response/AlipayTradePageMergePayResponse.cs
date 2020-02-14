using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradePageMergePayResponse : AopResponse
	{
		[XmlElement("merge_pay_status")]
		public string MergePayStatus
		{
			get;
			set;
		}

		[XmlArray("order_detail_results")]
		[XmlArrayItem("order_detail_result")]
		public List<OrderDetailResult> OrderDetailResults
		{
			get;
			set;
		}

		[XmlElement("out_merge_no")]
		public string OutMergeNo
		{
			get;
			set;
		}
	}
}
