using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseMcommentStudentQueryResponse : AopResponse
	{
		[XmlElement("campus_code")]
		public string CampusCode
		{
			get;
			set;
		}

		[XmlElement("campus_name")]
		public string CampusName
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

		[XmlElement("enrollment_time")]
		public string EnrollmentTime
		{
			get;
			set;
		}

		[XmlElement("graduation_time")]
		public string GraduationTime
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("province_name")]
		public string ProvinceName
		{
			get;
			set;
		}

		[XmlElement("status_enum")]
		public string StatusEnum
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
