using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class StudentInfo : AopObject
	{
		[XmlElement("city_no")]
		public string CityNo
		{
			get;
			set;
		}

		[XmlElement("class_name")]
		public string ClassName
		{
			get;
			set;
		}

		[XmlElement("college_name")]
		public string CollegeName
		{
			get;
			set;
		}

		[XmlElement("college_no")]
		public string CollegeNo
		{
			get;
			set;
		}

		[XmlElement("degree")]
		public string Degree
		{
			get;
			set;
		}

		[XmlElement("departments")]
		public string Departments
		{
			get;
			set;
		}

		[XmlElement("gmt_enrollment")]
		public string GmtEnrollment
		{
			get;
			set;
		}

		[XmlElement("gmt_graduation")]
		public string GmtGraduation
		{
			get;
			set;
		}

		[XmlElement("major")]
		public string Major
		{
			get;
			set;
		}

		[XmlElement("student_id")]
		public string StudentId
		{
			get;
			set;
		}
	}
}
