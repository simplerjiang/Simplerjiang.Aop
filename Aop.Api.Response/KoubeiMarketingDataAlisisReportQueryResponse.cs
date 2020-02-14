using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataAlisisReportQueryResponse : AopResponse
	{
		[XmlArray("report_data")]
		[XmlArrayItem("alisis_report_row")]
		public List<AlisisReportRow> ReportData
		{
			get;
			set;
		}
	}
}
