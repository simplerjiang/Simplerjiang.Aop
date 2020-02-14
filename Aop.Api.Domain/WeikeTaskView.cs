using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class WeikeTaskView : AopObject
	{
		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}

		[XmlElement("img")]
		public string Img
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

		[XmlElement("salary")]
		public string Salary
		{
			get;
			set;
		}

		[XmlElement("task_count")]
		public long TaskCount
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
