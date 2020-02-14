using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AliTrustRiskIdentify : AopObject
	{
		[XmlArray("details")]
		[XmlArrayItem("zhima_risk_detail")]
		public List<ZhimaRiskDetail> Details
		{
			get;
			set;
		}

		[XmlElement("is_risk")]
		public string IsRisk
		{
			get;
			set;
		}

		[XmlElement("risk_tag")]
		public string RiskTag
		{
			get;
			set;
		}
	}
}
