using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataAlisisReportQueryModel : AopObject
	{
		[XmlArray("conditions")]
		[XmlArrayItem("report_query_condition")]
		public List<ReportQueryCondition> Conditions
		{
			get;
			set;
		}

		[XmlElement("report_uk")]
		public string ReportUk
		{
			get;
			set;
		}
	}
}
