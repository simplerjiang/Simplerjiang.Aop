using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntarchiveFaceQueryModel : AopObject
	{
		[XmlElement("birthday")]
		public string Birthday
		{
			get;
			set;
		}

		[XmlElement("cert_expire_date")]
		public string CertExpireDate
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

		[XmlElement("gender")]
		public string Gender
		{
			get;
			set;
		}
	}
}
