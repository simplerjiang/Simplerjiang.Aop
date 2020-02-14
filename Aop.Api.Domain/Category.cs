using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Category : AopObject
	{
		[XmlArray("shop_cate_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopCateIds
		{
			get;
			set;
		}

		[XmlElement("shop_cate_name")]
		public string ShopCateName
		{
			get;
			set;
		}
	}
}
