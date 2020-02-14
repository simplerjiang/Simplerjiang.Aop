using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataAlisisReportBatchqueryResponse : AopResponse
	{
		[XmlArray("report_list")]
		[XmlArrayItem("alisis_report")]
		public List<AlisisReport> ReportList
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
