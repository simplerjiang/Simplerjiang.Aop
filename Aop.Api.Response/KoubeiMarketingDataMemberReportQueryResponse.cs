using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataMemberReportQueryResponse : AopResponse
	{
		[XmlElement("report_data")]
		public string ReportData
		{
			get;
			set;
		}
	}
}
