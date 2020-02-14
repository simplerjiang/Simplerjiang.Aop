using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiSpModifyModel : AopObject
	{
		[XmlElement("calendar_schedule")]
		public CalendarScheduleInfo CalendarSchedule
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlArray("license_list")]
		[XmlArrayItem("license_info")]
		public List<LicenseInfo> LicenseList
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
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

		[XmlElement("nick_name")]
		public string NickName
		{
			get;
			set;
		}

		[XmlElement("out_sp_id")]
		public string OutSpId
		{
			get;
			set;
		}

		[XmlElement("photo_url")]
		public string PhotoUrl
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
	}
}
