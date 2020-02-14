using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTrustUserAuthSendResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
