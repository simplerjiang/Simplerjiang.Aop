using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskAuthenticationCancelResponse : AopResponse
	{
		[XmlElement("biz_result")]
		public string BizResult
		{
			get;
			set;
		}
	}
}
