using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeOrderConsultResponse : AopResponse
	{
		[XmlElement("buyer_pay_amount")]
		public string BuyerPayAmount
		{
			get;
			set;
		}

		[XmlArray("discount_detail")]
		[XmlArrayItem("discount_detail")]
		public List<DiscountDetail> DiscountDetail
		{
			get;
			set;
		}

		[XmlElement("m_card_detail")]
		public MCardDetail MCardDetail
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
