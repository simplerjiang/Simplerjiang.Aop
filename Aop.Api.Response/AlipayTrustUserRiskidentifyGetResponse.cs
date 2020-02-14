using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTrustUserRiskidentifyGetResponse : AopResponse
	{
		[XmlElement("ali_trust_risk_identify")]
		public AliTrustRiskIdentify AliTrustRiskIdentify
		{
			get;
			set;
		}
	}
}
