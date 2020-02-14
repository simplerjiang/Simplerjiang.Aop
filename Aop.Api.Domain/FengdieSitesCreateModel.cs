using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSitesCreateModel : AopObject
	{
		[XmlElement("domain")]
		public string Domain
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

		[XmlElement("offline_time")]
		public string OfflineTime
		{
			get;
			set;
		}

		[XmlElement("page")]
		public FengdieActivityCreatePageData Page
		{
			get;
			set;
		}

		[XmlArray("pages")]
		[XmlArrayItem("fengdie_activity_create_pages_data")]
		public List<FengdieActivityCreatePagesData> Pages
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
