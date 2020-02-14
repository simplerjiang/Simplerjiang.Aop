using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditAntifraudRiskListResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("decision_result")]
		public string DecisionResult
		{
			get;
			set;
		}

		[XmlElement("hit_risk")]
		public string HitRisk
		{
			get;
			set;
		}

		[XmlArray("risk_code")]
		[XmlArrayItem("string")]
		public List<string> RiskCode
		{
			get;
			set;
		}

		[XmlElement("solution_id")]
		public string SolutionId
		{
			get;
			set;
		}
	}
}
