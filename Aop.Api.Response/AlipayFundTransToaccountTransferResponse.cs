using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransToaccountTransferResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("pay_date")]
		public string PayDate
		{
			get;
			set;
		}
	}
}
