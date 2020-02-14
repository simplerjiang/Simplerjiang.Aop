using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskRiskscanSingleQueryModel : AopObject
	{
		[XmlElement("app_key")]
		public string AppKey
		{
			get;
			set;
		}

		[XmlElement("event_data")]
		public string EventData
		{
			get;
			set;
		}

		[XmlElement("event_type")]
		public string EventType
		{
			get;
			set;
		}

		[XmlElement("secret_key")]
		public string SecretKey
		{
			get;
			set;
		}
	}
}
