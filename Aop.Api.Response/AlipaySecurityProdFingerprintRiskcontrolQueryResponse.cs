using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFingerprintRiskcontrolQueryResponse : AopResponse
	{
		[XmlElement("check_result")]
		public bool CheckResult
		{
			get;
			set;
		}
	}
}
