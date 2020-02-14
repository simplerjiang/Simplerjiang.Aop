using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertifyStudentinfoSyncModel : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("education_level")]
		public string EducationLevel
		{
			get;
			set;
		}

		[XmlElement("entry_date")]
		public string EntryDate
		{
			get;
			set;
		}

		[XmlElement("graduation_date")]
		public string GraduationDate
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
