using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FileSignature : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("seal_id")]
		public string SealId
		{
			get;
			set;
		}

		[XmlElement("seal_position")]
		public SealPosition SealPosition
		{
			get;
			set;
		}

		[XmlElement("seal_type")]
		public long SealType
		{
			get;
			set;
		}

		[XmlElement("sign_reason")]
		public string SignReason
		{
			get;
			set;
		}

		[XmlElement("signature_type")]
		public long SignatureType
		{
			get;
			set;
		}
	}
}
