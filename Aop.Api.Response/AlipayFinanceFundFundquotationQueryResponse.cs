using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceFundFundquotationQueryResponse : AopResponse
	{
		[XmlElement("last_half_year")]
		public string LastHalfYear
		{
			get;
			set;
		}

		[XmlElement("last_month")]
		public string LastMonth
		{
			get;
			set;
		}

		[XmlElement("last_quarter")]
		public string LastQuarter
		{
			get;
			set;
		}

		[XmlElement("last_week")]
		public string LastWeek
		{
			get;
			set;
		}

		[XmlElement("last_year")]
		public string LastYear
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

		[XmlElement("since_establishment")]
		public string SinceEstablishment
		{
			get;
			set;
		}

		[XmlElement("this_year")]
		public string ThisYear
		{
			get;
			set;
		}

		[XmlElement("yield_3_year")]
		public string Yield3Year
		{
			get;
			set;
		}

		[XmlElement("yield_5_year")]
		public string Yield5Year
		{
			get;
			set;
		}
	}
}
