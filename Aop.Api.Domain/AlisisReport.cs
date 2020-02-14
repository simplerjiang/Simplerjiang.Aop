using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlisisReport : AopObject
	{
		[XmlArray("conditions")]
		[XmlArrayItem("report_condition")]
		public List<ReportCondition> Conditions
		{
			get;
			set;
		}

		[XmlElement("report_desc")]
		public string ReportDesc
		{
			get;
			set;
		}

		[XmlElement("report_name")]
		public string ReportName
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
