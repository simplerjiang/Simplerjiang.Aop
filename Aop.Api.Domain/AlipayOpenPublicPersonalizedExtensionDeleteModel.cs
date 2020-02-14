using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPersonalizedExtensionDeleteModel : AopObject
	{
		[XmlElement("extension_key")]
		public string ExtensionKey
		{
			get;
			set;
		}
	}
}
