using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivityCreatePagesData : AopObject
	{
		[XmlArray("components")]
		[XmlArrayItem("fengdie_activity_component_model")]
		public List<FengdieActivityComponentModel> Components
		{
			get;
			set;
		}

		[XmlArray("page_data")]
		[XmlArrayItem("fengdie_activity_schema_model")]
		public List<FengdieActivitySchemaModel> PageData
		{
			get;
			set;
		}

		[XmlElement("page_path")]
		public string PagePath
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
	}
}
