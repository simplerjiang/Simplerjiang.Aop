using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceDeployorderResultSendResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
