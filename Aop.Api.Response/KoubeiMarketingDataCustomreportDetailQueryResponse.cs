using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataCustomreportDetailQueryResponse : AopResponse
	{
		[XmlElement("report_condition_info")]
		public CustomReportCondition ReportConditionInfo
		{
			get;
			set;
		}
	}
}
