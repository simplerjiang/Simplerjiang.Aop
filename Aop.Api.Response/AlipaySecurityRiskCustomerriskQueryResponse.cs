using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskCustomerriskQueryResponse : AopResponse
	{
		[XmlElement("risk_result")]
		public string RiskResult
		{
			get;
			set;
		}

		[XmlElement("risk_result_desc")]
		public string RiskResultDesc
		{
			get;
			set;
		}
	}
}
