using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketingVoucherOfflineResponse : AopResponse
	{
		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}

		[XmlElement("voucher_status")]
		public string VoucherStatus
		{
			get;
			set;
		}
	}
}
