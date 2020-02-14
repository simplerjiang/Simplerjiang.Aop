using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPersonalizedExtensionCreateModel : AopObject
	{
		[XmlArray("areas")]
		[XmlArrayItem("extension_area")]
		public List<ExtensionArea> Areas
		{
			get;
			set;
		}

		[XmlArray("label_rule")]
		[XmlArrayItem("label_rule")]
		public List<LabelRule> LabelRule
		{
			get;
			set;
		}
	}
}
