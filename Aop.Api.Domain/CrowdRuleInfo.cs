using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CrowdRuleInfo : AopObject
	{
		[XmlElement("ruledesc")]
		public string Ruledesc
		{
			get;
			set;
		}

		[XmlElement("ruleid")]
		public string Ruleid
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
