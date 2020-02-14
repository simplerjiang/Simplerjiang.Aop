using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceZcbEndowmentorderDetailQueryResponse : AopResponse
	{
		[XmlArray("order_list")]
		[XmlArrayItem("endowment_order")]
		public List<EndowmentOrder> OrderList
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public string TotalCount
		{
			get;
			set;
		}
	}
}
