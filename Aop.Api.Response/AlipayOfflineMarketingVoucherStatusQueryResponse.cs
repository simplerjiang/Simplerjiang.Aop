using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketingVoucherStatusQueryResponse : AopResponse
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

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
