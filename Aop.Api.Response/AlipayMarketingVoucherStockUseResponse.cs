using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherStockUseResponse : AopResponse
	{
		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
