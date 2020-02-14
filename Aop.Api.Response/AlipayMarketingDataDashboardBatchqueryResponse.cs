using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataDashboardBatchqueryResponse : AopResponse
	{
		[XmlArray("dashboard_list")]
		[XmlArrayItem("dash_board_meta")]
		public List<DashBoardMeta> DashboardList
		{
			get;
			set;
		}

		[XmlElement("total_page_count")]
		public string TotalPageCount
		{
			get;
			set;
		}
	}
}
