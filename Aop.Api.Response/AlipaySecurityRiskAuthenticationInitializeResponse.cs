using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskAuthenticationInitializeResponse : AopResponse
	{
		[XmlElement("biz_result")]
		public string BizResult
		{
			get;
			set;
		}

		[XmlElement("token_id")]
		public string TokenId
		{
			get;
			set;
		}
	}
}
