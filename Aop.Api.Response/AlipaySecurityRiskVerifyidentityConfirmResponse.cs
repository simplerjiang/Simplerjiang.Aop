using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskVerifyidentityConfirmResponse : AopResponse
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("verify_result")]
		public bool VerifyResult
		{
			get;
			set;
		}
	}
}
