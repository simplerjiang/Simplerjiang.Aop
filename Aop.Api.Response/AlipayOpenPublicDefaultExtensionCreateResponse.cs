using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicDefaultExtensionCreateResponse : AopResponse
	{
		[XmlElement("extension_key")]
		public string ExtensionKey
		{
			get;
			set;
		}
	}
}
