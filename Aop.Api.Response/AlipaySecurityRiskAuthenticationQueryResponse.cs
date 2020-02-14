using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskAuthenticationQueryResponse : AopResponse
	{
		[XmlElement("biz_result")]
		public string BizResult
		{
			get;
			set;
		}
	}
}
