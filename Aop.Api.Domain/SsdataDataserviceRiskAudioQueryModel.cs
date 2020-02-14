using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAudioQueryModel : AopObject
	{
		[XmlElement("checker")]
		public string Checker
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlArray("risk_type")]
		[XmlArrayItem("string")]
		public List<string> RiskType
		{
			get;
			set;
		}
	}
}
