using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DataEnumValue : AopObject
	{
		[XmlArray("filter_tags")]
		[XmlArrayItem("filter_tag")]
		public List<FilterTag> FilterTags
		{
			get;
			set;
		}

		[XmlElement("label")]
		public string Label
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
