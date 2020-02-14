using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationCustomerIdcardCertifyResponse : AopResponse
	{
		[XmlArray("cert_audit_result")]
		[XmlArrayItem("cert_audit_result")]
		public List<CertAuditResult> CertAuditResult
		{
			get;
			set;
		}

		[XmlElement("passed")]
		public bool Passed
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
