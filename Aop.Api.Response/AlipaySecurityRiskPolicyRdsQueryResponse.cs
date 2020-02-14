using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskPolicyRdsQueryResponse : AopResponse
	{
		[XmlElement("rds_result")]
		public string RdsResult
		{
			get;
			set;
		}
	}
}
