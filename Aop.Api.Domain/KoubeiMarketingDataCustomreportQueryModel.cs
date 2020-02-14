using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataCustomreportQueryModel : AopObject
	{
		[XmlElement("condition_key")]
		public string ConditionKey
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

		[XmlElement("max_count")]
		public string MaxCount
		{
			get;
			set;
		}
	}
}
