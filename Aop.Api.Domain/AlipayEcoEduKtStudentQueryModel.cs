using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduKtStudentQueryModel : AopObject
	{
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

		[XmlElement("student_no")]
		public string StudentNo
		{
			get;
			set;
		}
	}
}
