using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataAiserviceJunengLoanQueryModel : AopObject
	{
		[XmlElement("extension_info")]
		public string ExtensionInfo
		{
			get;
			set;
		}

		[XmlElement("hashed_cert_no")]
		public string HashedCertNo
		{
			get;
			set;
		}

		[XmlElement("institution_uuid")]
		public string InstitutionUuid
		{
			get;
			set;
		}

		[XmlElement("request_uuid")]
		public string RequestUuid
		{
			get;
			set;
		}

		[XmlElement("user_feature")]
		public string UserFeature
		{
			get;
			set;
		}
	}
}
