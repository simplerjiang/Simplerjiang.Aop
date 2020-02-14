using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherStockCreateResponse : AopResponse
	{
		[XmlElement("duplicate_count")]
		public long DuplicateCount
		{
			get;
			set;
		}

		[XmlElement("fail_count")]
		public long FailCount
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

		[XmlElement("success_count")]
		public long SuccessCount
		{
			get;
			set;
		}
	}
}
