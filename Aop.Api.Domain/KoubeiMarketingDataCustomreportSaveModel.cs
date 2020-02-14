using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataCustomreportSaveModel : AopObject
	{
		[XmlElement("report_condition_info")]
		public CustomReportCondition ReportConditionInfo
		{
			get;
			set;
		}
	}
}
