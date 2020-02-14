using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingVoucherStockMatchModel : AopObject
	{
		[XmlArray("entity_list")]
		[XmlArrayItem("string")]
		public List<string> EntityList
		{
			get;
			set;
		}

		[XmlElement("stock_id")]
		public string StockId
		{
			get;
			set;
		}
	}
}
