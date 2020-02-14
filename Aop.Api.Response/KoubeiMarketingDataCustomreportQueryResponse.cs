using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataCustomreportQueryResponse : AopResponse
	{
		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlArray("report_data")]
		[XmlArrayItem("report_data_item")]
		public List<ReportDataItem> ReportData
		{
			get;
			set;
		}
	}
}
