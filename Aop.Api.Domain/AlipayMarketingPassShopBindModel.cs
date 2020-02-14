using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingPassShopBindModel : AopObject
	{
		[XmlElement("is_appending")]
		public bool IsAppending
		{
			get;
			set;
		}

		[XmlArray("shop_list")]
		[XmlArrayItem("string")]
		public List<string> ShopList
		{
			get;
			set;
		}

		[XmlElement("tpl_id")]
		public string TplId
		{
			get;
			set;
		}
	}
}
