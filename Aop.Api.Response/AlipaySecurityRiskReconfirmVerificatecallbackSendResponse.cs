using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskReconfirmVerificatecallbackSendResponse : AopResponse
	{
		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}
	}
}
