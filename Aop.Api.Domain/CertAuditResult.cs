using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CertAuditResult : AopObject
	{
		[XmlElement("authority_check_retcode")]
		public string AuthorityCheckRetcode
		{
			get;
			set;
		}

		[XmlElement("authority_check_retmessage")]
		public string AuthorityCheckRetmessage
		{
			get;
			set;
		}

		[XmlElement("authority_check_suggest")]
		public string AuthorityCheckSuggest
		{
			get;
			set;
		}

		[XmlElement("cert_face_suggest")]
		public string CertFaceSuggest
		{
			get;
			set;
		}

		[XmlElement("compliance_suggest")]
		public string ComplianceSuggest
		{
			get;
			set;
		}

		[XmlElement("ocr")]
		public CertFields Ocr
		{
			get;
			set;
		}

		[XmlElement("ocr_check_suggest")]
		public string OcrCheckSuggest
		{
			get;
			set;
		}
	}
}
