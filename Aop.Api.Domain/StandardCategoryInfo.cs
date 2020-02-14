using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class StandardCategoryInfo : AopObject
	{
		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("is_leaf")]
		public string IsLeaf
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

		[XmlElement("parent_id")]
		public string ParentId
		{
			get;
			set;
		}

		[XmlElement("path")]
		public string Path
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
