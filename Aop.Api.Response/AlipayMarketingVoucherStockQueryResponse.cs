using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherStockQueryResponse : AopResponse
	{
		[XmlElement("available_count")]
		public long AvailableCount
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
