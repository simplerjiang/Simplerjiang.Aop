using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CategoryVO : AopObject
	{
		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("category_name")]
		public string CategoryName
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("enable")]
		public long Enable
		{
			get;
			set;
		}

		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}

		[XmlElement("parent_id")]
		public string ParentId
		{
			get;
			set;
		}

		[XmlElement("root_id")]
		public string RootId
		{
			get;
			set;
		}
	}
}
