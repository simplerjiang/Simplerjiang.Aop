using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMessageTotalSendResponse : AopResponse
	{
		[XmlElement("message_id")]
		public string MessageId
		{
			get;
			set;
		}
	}
}
