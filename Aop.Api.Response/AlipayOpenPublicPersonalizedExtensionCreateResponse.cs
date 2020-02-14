using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicPersonalizedExtensionCreateResponse : AopResponse
	{
		[XmlElement("extension_key")]
		public string ExtensionKey
		{
			get;
			set;
		}
	}
}
