using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderRentCompleteResponse : AopResponse
	{
		[XmlElement("alipay_fund_order_no")]
		public string AlipayFundOrderNo
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
