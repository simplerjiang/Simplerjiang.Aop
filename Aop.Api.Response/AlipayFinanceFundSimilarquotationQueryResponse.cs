using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinanceFundSimilarquotationQueryResponse : AopResponse
	{
		[XmlElement("last_half_year_count")]
		public string LastHalfYearCount
		{
			get;
			set;
		}

		[XmlElement("last_half_year_order")]
		public string LastHalfYearOrder
		{
			get;
			set;
		}

		[XmlElement("last_half_year_similar")]
		public string LastHalfYearSimilar
		{
			get;
			set;
		}

		[XmlElement("last_month_count")]
		public string LastMonthCount
		{
			get;
			set;
		}

		[XmlElement("last_month_order")]
		public string LastMonthOrder
		{
			get;
			set;
		}

		[XmlElement("last_month_similar")]
		public string LastMonthSimilar
		{
			get;
			set;
		}

		[XmlElement("last_quarter_count")]
		public string LastQuarterCount
		{
			get;
			set;
		}

		[XmlElement("last_quarter_order")]
		public string LastQuarterOrder
		{
			get;
			set;
		}

		[XmlElement("last_quarter_similar")]
		public string LastQuarterSimilar
		{
			get;
			set;
		}

		[XmlElement("last_year_count")]
		public string LastYearCount
		{
			get;
			set;
		}

		[XmlElement("last_year_order")]
		public string LastYearOrder
		{
			get;
			set;
		}

		[XmlElement("last_year_similar")]
		public string LastYearSimilar
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

		[XmlElement("yield_three_year_count")]
		public string YieldThreeYearCount
		{
			get;
			set;
		}

		[XmlElement("yield_three_year_order")]
		public string YieldThreeYearOrder
		{
			get;
			set;
		}

		[XmlElement("yield_three_year_similar")]
		public string YieldThreeYearSimilar
		{
			get;
			set;
		}
	}
}
