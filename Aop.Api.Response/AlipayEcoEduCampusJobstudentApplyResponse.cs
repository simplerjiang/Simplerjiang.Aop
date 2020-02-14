using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduCampusJobstudentApplyResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("content_var")]
		public string ContentVar
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

		[XmlElement("description")]
		public string Description
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

		[XmlElement("is_graduate")]
		public long IsGraduate
		{
			get;
			set;
		}

		[XmlElement("is_student")]
		public long IsStudent
		{
			get;
			set;
		}

		[XmlElement("isv_code")]
		public string IsvCode
		{
			get;
			set;
		}

		[XmlElement("school")]
		public string School
		{
			get;
			set;
		}
	}
}
