using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketProductBatchqueryResponse : AopResponse
	{
		[XmlElement("current_pageno")]
		public long CurrentPageno
		{
			get;
			set;
		}

		[XmlArray("item_ids")]
		[XmlArrayItem("string")]
		public List<string> ItemIds
		{
			get;
			set;
		}

		[XmlElement("total_pageno")]
		public long TotalPageno
		{
			get;
			set;
		}
	}
}
