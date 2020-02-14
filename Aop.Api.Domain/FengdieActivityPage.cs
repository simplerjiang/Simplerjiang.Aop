using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivityPage : AopObject
	{
		[XmlElement("id")]
		public long Id
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

		[XmlArray("schema")]
		[XmlArrayItem("fengdie_activity_schema_data")]
		public List<FengdieActivitySchemaData> Schema
		{
			get;
			set;
		}

		[XmlElement("snapshot")]
		public string Snapshot
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
