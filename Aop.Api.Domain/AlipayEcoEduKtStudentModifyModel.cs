using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduKtStudentModifyModel : AopObject
	{
		[XmlElement("child_name")]
		public string ChildName
		{
			get;
			set;
		}

		[XmlElement("isv_pid")]
		public string IsvPid
		{
			get;
			set;
		}

		[XmlElement("school_no")]
		public string SchoolNo
		{
			get;
			set;
		}

		[XmlElement("school_pid")]
		public string SchoolPid
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

		[XmlElement("student_no")]
		public string StudentNo
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
