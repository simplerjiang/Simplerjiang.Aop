using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LegalRepresentativeInfo : AopObject
	{
		[XmlElement("legal_representative_cert_indate")]
		public string LegalRepresentativeCertIndate
		{
			get;
			set;
		}

		[XmlElement("legal_representative_cert_no")]
		public string LegalRepresentativeCertNo
		{
			get;
			set;
		}

		[XmlElement("legal_representative_cert_pic_back")]
		public string LegalRepresentativeCertPicBack
		{
			get;
			set;
		}

		[XmlElement("legal_representative_cert_pic_front")]
		public string LegalRepresentativeCertPicFront
		{
			get;
			set;
		}

		[XmlElement("legal_representative_cert_type")]
		public string LegalRepresentativeCertType
		{
			get;
			set;
		}

		[XmlElement("legal_representative_name")]
		public string LegalRepresentativeName
		{
			get;
			set;
		}
	}
}
