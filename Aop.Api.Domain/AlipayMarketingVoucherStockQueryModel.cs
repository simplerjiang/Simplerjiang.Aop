using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingVoucherStockQueryModel : AopObject
	{
		[XmlElement("stock_id")]
		public string StockId
		{
			get;
			set;
		}
	}
}
