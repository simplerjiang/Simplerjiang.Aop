using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MedicalHospitalReportList : AopObject
	{
		[XmlElement("report_date")]
		public string ReportDate
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

		[XmlElement("report_link")]
		public string ReportLink
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

		[XmlElement("report_type")]
		public string ReportType
		{
			get;
			set;
		}
	}
}
