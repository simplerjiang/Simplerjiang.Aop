using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankFinanceYulibaoTransHistoryQueryResponse : AopResponse
	{
		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlElement("has_next_page")]
		public bool HasNextPage
		{
			get;
			set;
		}

		[XmlArray("history_trans_detail_infos")]
		[XmlArrayItem("y_l_b_trans_detail_info")]
		public List<YLBTransDetailInfo> HistoryTransDetailInfos
		{
			get;
			set;
		}

		[XmlElement("total_item_count")]
		public string TotalItemCount
		{
			get;
			set;
		}
	}
}
