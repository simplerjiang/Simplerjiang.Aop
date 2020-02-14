using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAntiscalperQueryModel : AopObject
	{
		[XmlElement("apdid")]
		public string Apdid
		{
			get;
			set;
		}

		[XmlElement("ip")]
		public string Ip
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

		[XmlElement("umid")]
		public string Umid
		{
			get;
			set;
		}
	}
}
