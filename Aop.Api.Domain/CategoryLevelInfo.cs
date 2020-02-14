using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CategoryLevelInfo : AopObject
	{
		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("category_level")]
		public long CategoryLevel
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
	}
}
