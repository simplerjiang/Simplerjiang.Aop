using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPersonalizedExtensionSetModel : AopObject
	{
		[XmlElement("extension_key")]
		public string ExtensionKey
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
