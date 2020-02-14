using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSitesPageModel : AopObject
	{
		[XmlElement("alias")]
		public string Alias
		{
			get;
			set;
		}

		[XmlArray("schema")]
		[XmlArrayItem("fengdie_activity_schema_model")]
		public List<FengdieActivitySchemaModel> Schema
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

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
