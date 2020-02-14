using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopSummaryBatchqueryResponse : AopResponse
	{
		[XmlElement("current_page_no")]
		public string CurrentPageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlArray("shop_summary_infos")]
		[XmlArrayItem("shop_summary_query_response")]
		public List<ShopSummaryQueryResponse> ShopSummaryInfos
		{
			get;
			set;
		}

		[XmlElement("total_items")]
		public string TotalItems
		{
			get;
			set;
		}

		[XmlElement("total_page_no")]
		public string TotalPageNo
		{
			get;
			set;
		}
	}
}
