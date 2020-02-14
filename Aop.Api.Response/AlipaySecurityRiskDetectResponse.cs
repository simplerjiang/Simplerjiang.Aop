using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskDetectResponse : AopResponse
	{
		[XmlElement("risk_code")]
		public string RiskCode
		{
			get;
			set;
		}

		[XmlElement("risk_level")]
		public long RiskLevel
		{
			get;
			set;
		}
	}
}
