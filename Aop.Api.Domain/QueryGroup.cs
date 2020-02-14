using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QueryGroup : AopObject
	{
		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlArray("label_rule")]
		[XmlArrayItem("query_complex_label_rule")]
		public List<QueryComplexLabelRule> LabelRule
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
