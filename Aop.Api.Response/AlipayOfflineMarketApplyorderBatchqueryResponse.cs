using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketApplyorderBatchqueryResponse : AopResponse
	{
		[XmlArray("biz_order_infos")]
		[XmlArrayItem("biz_order_query_response")]
		public List<BizOrderQueryResponse> BizOrderInfos
		{
			get;
			set;
		}

		[XmlElement("current_page_no")]
		public long CurrentPageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("total_items")]
		public long TotalItems
		{
			get;
			set;
		}

		[XmlElement("total_page_no")]
		public long TotalPageNo
		{
			get;
			set;
		}
	}
}
