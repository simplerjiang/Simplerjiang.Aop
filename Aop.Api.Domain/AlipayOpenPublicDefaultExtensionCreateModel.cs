using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicDefaultExtensionCreateModel : AopObject
	{
		[XmlArray("areas")]
		[XmlArrayItem("extension_area")]
		public List<ExtensionArea> Areas
		{
			get;
			set;
		}
	}
}
