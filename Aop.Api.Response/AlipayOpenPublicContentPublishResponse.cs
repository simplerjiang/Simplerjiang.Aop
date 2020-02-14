using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicContentPublishResponse : AopResponse
	{
		[XmlElement("message_id")]
		public string MessageId
		{
			get;
			set;
		}
	}
}
