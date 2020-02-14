using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherAuthSendResponse : AopResponse
	{
		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
