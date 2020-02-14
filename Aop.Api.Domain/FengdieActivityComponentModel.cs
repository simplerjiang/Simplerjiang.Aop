using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivityComponentModel : AopObject
	{
		[XmlArray("component_data")]
		[XmlArrayItem("fengdie_activity_schema_model")]
		public List<FengdieActivitySchemaModel> ComponentData
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
