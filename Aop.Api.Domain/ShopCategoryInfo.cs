using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopCategoryInfo : AopObject
	{
		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("category_level")]
		public string CategoryLevel
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
