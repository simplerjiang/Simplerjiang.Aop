using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryMenu : AopObject
	{
		[XmlArray("button")]
		[XmlArrayItem("button_object")]
		public List<ButtonObject> Button
		{
			get;
			set;
		}

		[XmlArray("label_rule")]
		[XmlArrayItem("query_label_rule")]
		public List<QueryLabelRule> LabelRule
		{
			get;
			set;
		}

		[XmlElement("menu_key")]
		public string MenuKey
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
