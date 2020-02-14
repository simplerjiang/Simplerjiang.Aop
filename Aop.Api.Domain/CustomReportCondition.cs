using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CustomReportCondition : AopObject
	{
		[XmlElement("condition_key")]
		public string ConditionKey
		{
			get;
			set;
		}

		[XmlArray("data_tags")]
		[XmlArrayItem("data_tag")]
		public List<DataTag> DataTags
		{
			get;
			set;
		}

		[XmlArray("filter_tags")]
		[XmlArrayItem("filter_tag")]
		public List<FilterTag> FilterTags
		{
			get;
			set;
		}

		[XmlElement("group_tags")]
		public string GroupTags
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("sort_tags")]
		public string SortTags
		{
			get;
			set;
		}
	}
}
