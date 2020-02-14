using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskReconfirmRiskidentifyCertifyResponse : AopResponse
	{
		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("has_risk")]
		public bool HasRisk
		{
			get;
			set;
		}

		[XmlElement("identify_id")]
		public string IdentifyId
		{
			get;
			set;
		}
	}
}
