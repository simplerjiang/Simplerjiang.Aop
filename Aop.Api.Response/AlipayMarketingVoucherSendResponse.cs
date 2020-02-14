using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherSendResponse : AopResponse
	{
		[XmlElement("user_id")]
		public string UserId
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
