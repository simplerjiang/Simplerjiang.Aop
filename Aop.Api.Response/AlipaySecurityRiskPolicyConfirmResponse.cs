using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskPolicyConfirmResponse : AopResponse
	{
		[XmlElement("confirm_success")]
		public bool ConfirmSuccess
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
