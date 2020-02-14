using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketingVoucherCreateResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public string ActivityId
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
	}
}
