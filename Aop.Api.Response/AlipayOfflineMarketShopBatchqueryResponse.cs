using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopBatchqueryResponse : AopResponse
	{
		[XmlElement("current_pageno")]
		public string CurrentPageno
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

		[XmlElement("total_pageno")]
		public string TotalPageno
		{
			get;
			set;
		}
	}
}
