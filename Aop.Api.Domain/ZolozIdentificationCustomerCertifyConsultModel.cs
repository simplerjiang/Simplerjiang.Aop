using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZolozIdentificationCustomerCertifyConsultModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("cert_name")]
		public string CertName
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

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
