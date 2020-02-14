using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPersonalizedMenuCreateModel : AopObject
	{
		[XmlArray("button")]
		[XmlArrayItem("button_object")]
		public List<ButtonObject> Button
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

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
