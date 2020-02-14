using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderPayQueryResponse : AopResponse
	{
		[XmlArray("discount_details")]
		[XmlArrayItem("pos_discount_detail")]
		public List<PosDiscountDetail> DiscountDetails
		{
			get;
			set;
		}

		[XmlElement("out_pay_no")]
		public string OutPayNo
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

		[XmlElement("pay_no")]
		public string PayNo
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("receipt_amount")]
		public string ReceiptAmount
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

		[XmlElement("trade_no")]
		public string TradeNo
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
