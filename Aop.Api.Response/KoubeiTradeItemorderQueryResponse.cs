using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeItemorderQueryResponse : AopResponse
	{
		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("buyer_id")]
		public string BuyerId
		{
			get;
			set;
		}

		[XmlElement("discount_amount")]
		public string DiscountAmount
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("gmt_payment")]
		public string GmtPayment
		{
			get;
			set;
		}

		[XmlArray("item_order_vo")]
		[XmlArrayItem("item_order_v_o")]
		public List<ItemOrderVO> ItemOrderVo
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

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("real_pay_amount")]
		public string RealPayAmount
		{
			get;
			set;
		}

		[XmlElement("seller_id")]
		public string SellerId
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
	}
}
