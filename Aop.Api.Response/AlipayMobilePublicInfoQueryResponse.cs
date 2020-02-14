using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicInfoQueryResponse : AopResponse
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

		[XmlElement("public_greeting")]
		public string PublicGreeting
		{
			get;
			set;
		}
	}
}
