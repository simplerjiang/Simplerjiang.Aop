using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCdpAdvertiseReportQueryResponse : AopResponse
	{
		[XmlElement("click_pv_dd")]
		public string ClickPvDd
		{
			get;
			set;
		}

		[XmlElement("click_pv_history")]
		public string ClickPvHistory
		{
			get;
			set;
		}

		[XmlElement("click_uv_dd")]
		public string ClickUvDd
		{
			get;
			set;
		}

		[XmlElement("click_uv_history")]
		public string ClickUvHistory
		{
			get;
			set;
		}

		[XmlElement("report_date")]
		public string ReportDate
		{
			get;
			set;
		}

		[XmlElement("show_pv_dd")]
		public string ShowPvDd
		{
			get;
			set;
		}

		[XmlElement("show_pv_history")]
		public string ShowPvHistory
		{
			get;
			set;
		}

		[XmlElement("show_uv_dd")]
		public string ShowUvDd
		{
			get;
			set;
		}

		[XmlElement("show_uv_history")]
		public string ShowUvHistory
		{
			get;
			set;
		}
	}
}
