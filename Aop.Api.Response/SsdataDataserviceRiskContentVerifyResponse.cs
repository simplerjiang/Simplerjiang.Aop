using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskContentVerifyResponse : AopResponse
	{
		[XmlArray("risk_result")]
		[XmlArrayItem("risk_result")]
		public List<RiskResult> RiskResult
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

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}
