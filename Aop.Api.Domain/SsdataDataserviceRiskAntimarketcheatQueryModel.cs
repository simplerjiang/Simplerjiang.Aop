using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAntimarketcheatQueryModel : AopObject
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement("risk_code")]
		public string RiskCode
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}

		[XmlElement("sys_version")]
		public string SysVersion
		{
			get;
			set;
		}
	}
}
