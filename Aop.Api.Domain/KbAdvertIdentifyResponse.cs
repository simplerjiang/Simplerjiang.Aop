using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertIdentifyResponse : AopObject
	{
		[XmlArray("benefit_ids")]
		[XmlArrayItem("string")]
		public List<string> BenefitIds
		{
			get;
			set;
		}

		[XmlElement("benefit_type")]
		public string BenefitType
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("identify")]
		public string Identify
		{
			get;
			set;
		}

		[XmlElement("identify_type")]
		public string IdentifyType
		{
			get;
			set;
		}
	}
}
