using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdSignatureTaskCancelResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
