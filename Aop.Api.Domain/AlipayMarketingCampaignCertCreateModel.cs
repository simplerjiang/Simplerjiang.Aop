using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignCertCreateModel : AopObject
	{
		[XmlElement("cert_name")]
		public string CertName
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("valid_count")]
		public string ValidCount
		{
			get;
			set;
		}
	}
}
