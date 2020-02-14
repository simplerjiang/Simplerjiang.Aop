using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlisisReportRow : AopObject
	{
		[XmlArray("row_data")]
		[XmlArrayItem("alisis_report_column")]
		public List<AlisisReportColumn> RowData
		{
			get;
			set;
		}
	}
}
