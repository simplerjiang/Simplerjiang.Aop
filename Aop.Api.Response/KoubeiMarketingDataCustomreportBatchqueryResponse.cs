using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataCustomreportBatchqueryResponse : AopResponse
	{
		[XmlArray("report_condition_list")]
		[XmlArrayItem("custom_report_condition")]
		public List<CustomReportCondition> ReportConditionList
		{
			get;
			set;
		}
	}
}
