using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivityCreateData : AopObject
	{
		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("offline_time")]
		public string OfflineTime
		{
			get;
			set;
		}

		[XmlArray("page")]
		[XmlArrayItem("fengdie_activity_create_page_data")]
		public List<FengdieActivityCreatePageData> Page
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
