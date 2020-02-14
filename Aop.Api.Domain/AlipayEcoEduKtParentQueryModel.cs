using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduKtParentQueryModel : AopObject
	{
		[XmlElement("child_name")]
		public string ChildName
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
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

		[XmlElement("user_mobile")]
		public string UserMobile
		{
			get;
			set;
		}
	}
}
