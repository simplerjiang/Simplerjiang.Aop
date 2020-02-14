using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeMergePrecreateResponse : AopResponse
	{
		[XmlArray("order_detail_results")]
		[XmlArrayItem("pre_order_result")]
		public List<PreOrderResult> OrderDetailResults
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

		[XmlElement("pre_order_no")]
		public string PreOrderNo
		{
			get;
			set;
		}
	}
}
