using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataItemGoodsList : AopObject
	{
		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlArray("goods_list")]
		[XmlArrayItem("string")]
		public List<string> GoodsList
		{
			get;
			set;
		}
	}
}
