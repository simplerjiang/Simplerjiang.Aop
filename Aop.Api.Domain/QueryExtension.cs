using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryExtension : AopObject
	{
		[XmlArray("areas")]
		[XmlArrayItem("extension_area")]
		public List<ExtensionArea> Areas
		{
			get;
			set;
		}

		[XmlElement("extension_key")]
		public string ExtensionKey
		{
			get;
			set;
		}

		[XmlArray("label_rules")]
		[XmlArrayItem("query_label_rule")]
		public List<QueryLabelRule> LabelRules
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
