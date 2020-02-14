using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAudioVerifyModel : AopObject
	{
		[XmlElement("audio_content")]
		public string AudioContent
		{
			get;
			set;
		}

		[XmlElement("audio_type")]
		public string AudioType
		{
			get;
			set;
		}

		[XmlElement("checker")]
		public string Checker
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

		[XmlElement("sample_rate")]
		public string SampleRate
		{
			get;
			set;
		}
	}
}
