using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemBatchqueryResponse : AopResponse
	{
		[XmlElement("current_page_no")]
		public string CurrentPageNo
		{
			get;
			set;
		}

		[XmlArray("item_infos")]
		[XmlArrayItem("item_query_response")]
		public List<ItemQueryResponse> ItemInfos
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
