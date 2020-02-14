using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtStudentQueryResponse : AopResponse
	{
		[XmlElement("child_name")]
		public string ChildName
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

		[XmlElement("school_name")]
		public string SchoolName
		{
			get;
			set;
		}

		[XmlElement("student_code")]
		public string StudentCode
		{
			get;
			set;
		}

		[XmlElement("student_identify")]
		public string StudentIdentify
		{
			get;
			set;
		}

		[XmlArray("users")]
		[XmlArrayItem("user_details")]
		public List<UserDetails> Users
		{
			get;
			set;
		}
	}
}
