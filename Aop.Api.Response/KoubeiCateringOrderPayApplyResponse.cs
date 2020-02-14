using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderPayApplyResponse : AopResponse
	{
		[XmlElement("out_pay_no")]
		public string OutPayNo
		{
			get;
			set;
		}

		[XmlElement("pay_no")]
		public string PayNo
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
