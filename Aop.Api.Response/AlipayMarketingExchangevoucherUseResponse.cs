using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingExchangevoucherUseResponse : AopResponse
	{
		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
