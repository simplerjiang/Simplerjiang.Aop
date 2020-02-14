using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMessageContentCreateResponse : AopResponse
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("content_url")]
		public string ContentUrl
		{
			get;
			set;
		}
	}
}
