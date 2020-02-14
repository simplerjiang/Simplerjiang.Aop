using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsCertificate : AopObject
	{
		[XmlElement("certificate_id")]
		public string CertificateId
		{
			get;
			set;
		}

		[XmlElement("certificate_type")]
		public string CertificateType
		{
			get;
			set;
		}

		[XmlElement("certificate_value")]
		public string CertificateValue
		{
			get;
			set;
		}
	}
}
