using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RiskResult : AopObject
	{
		[XmlElement("risk_type")]
		public string RiskType
		{
			get;
			set;
		}

		[XmlElement("score")]
		public string Score
		{
			get;
			set;
		}
	}
}
