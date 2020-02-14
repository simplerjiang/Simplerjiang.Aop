using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingMallShoppromoinfoQueryModel : AopObject
	{
		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
		{
			get;
			set;
		}
	}
}
