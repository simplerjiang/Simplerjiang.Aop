using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskVerifyidentityInitializeResponse : AopResponse
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("err_msg")]
		public string ErrMsg
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("is_success")]
		public string IsSuccess
		{
			get;
			set;
		}

		[XmlElement("verify_url")]
		public string VerifyUrl
		{
			get;
			set;
		}

		[XmlElement("veritfy_token")]
		public string VeritfyToken
		{
			get;
			set;
		}
	}
}
