using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodUserCertifyResponse : AopResponse
	{
		[XmlElement("agent_cert_result")]
		public string AgentCertResult
		{
			get;
			set;
		}
	}
}
