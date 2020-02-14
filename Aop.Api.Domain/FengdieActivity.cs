using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivity : AopObject
	{
		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}

		[XmlElement("is_online")]
		public bool IsOnline
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

		[XmlElement("nick_name")]
		public string NickName
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
		[XmlArrayItem("fengdie_activity_page")]
		public List<FengdieActivityPage> Page
		{
			get;
			set;
		}

		[XmlElement("publish_time")]
		public string PublishTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public long TemplateId
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
