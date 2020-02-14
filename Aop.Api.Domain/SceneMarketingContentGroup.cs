using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneMarketingContentGroup : AopObject
	{
		[XmlArray("data_list")]
		[XmlArrayItem("scene_marketing_content")]
		public List<SceneMarketingContent> DataList
		{
			get;
			set;
		}

		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}

		[XmlElement("summary")]
		public string Summary
		{
			get;
			set;
		}
	}
}
