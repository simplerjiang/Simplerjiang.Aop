using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMessageGroupSendResponse : AopResponse
	{
		[XmlElement("message_id")]
		public string MessageId
		{
			get;
			set;
		}
	}
}
