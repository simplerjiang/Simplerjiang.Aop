using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BPOpenApiAddSignContent : AopObject
	{
		[XmlArray("additional_lines")]
		[XmlArrayItem("string")]
		public List<string> AdditionalLines
		{
			get;
			set;
		}

		[XmlElement("assignee")]
		public string Assignee
		{
			get;
			set;
		}

		[XmlElement("deal_actions")]
		public string DealActions
		{
			get;
			set;
		}

		[XmlElement("deal_url")]
		public string DealUrl
		{
			get;
			set;
		}

		[XmlElement("detail_url")]
		public string DetailUrl
		{
			get;
			set;
		}

		[XmlElement("display_name")]
		public string DisplayName
		{
			get;
			set;
		}
	}
}
