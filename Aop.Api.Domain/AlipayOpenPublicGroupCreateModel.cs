using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicGroupCreateModel : AopObject
	{
		[XmlArray("label_rule")]
		[XmlArrayItem("complex_label_rule")]
		public List<ComplexLabelRule> LabelRule
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
