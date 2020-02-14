using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicInfoQueryResponse : AopResponse
	{
		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("audit_desc")]
		public string AuditDesc
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlArray("audit_status_list")]
		[XmlArrayItem("public_audit_status")]
		public List<PublicAuditStatus> AuditStatusList
		{
			get;
			set;
		}

		[XmlElement("background_url")]
		public string BackgroundUrl
		{
			get;
			set;
		}

		[XmlElement("introduction")]
		public string Introduction
		{
			get;
			set;
		}

		[XmlElement("is_online")]
		public string IsOnline
		{
			get;
			set;
		}

		[XmlElement("is_release")]
		public string IsRelease
		{
			get;
			set;
		}

		[XmlElement("logo_url")]
		public string LogoUrl
		{
			get;
			set;
		}

		[XmlElement("mcc_code_desc")]
		public string MccCodeDesc
		{
			get;
			set;
		}

		[XmlElement("public_greeting")]
		public string PublicGreeting
		{
			get;
			set;
		}
	}
}
