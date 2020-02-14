using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceVerificationResultSendResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
