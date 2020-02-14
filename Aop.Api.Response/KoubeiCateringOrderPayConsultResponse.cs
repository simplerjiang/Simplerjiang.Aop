using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderPayConsultResponse : AopResponse
	{
		[XmlArray("discount_details")]
		[XmlArrayItem("discount_detail")]
		public List<DiscountDetail> DiscountDetails
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

		[XmlElement("pay_amount")]
		public string PayAmount
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

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
