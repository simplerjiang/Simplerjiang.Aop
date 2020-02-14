using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderInfoQueryResponse : AopResponse
	{
		[XmlElement("bill_amount")]
		public string BillAmount
		{
			get;
			set;
		}

		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("business_type")]
		public string BusinessType
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("dinner_type")]
		public string DinnerType
		{
			get;
			set;
		}

		[XmlArray("dish_details")]
		[XmlArrayItem("kb_pos_order_dish_detail")]
		public List<KbPosOrderDishDetail> DishDetails
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("member_flag")]
		public string MemberFlag
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_style")]
		public string OrderStyle
		{
			get;
			set;
		}

		[XmlElement("order_time")]
		public string OrderTime
		{
			get;
			set;
		}

		[XmlElement("other_amount")]
		public string OtherAmount
		{
			get;
			set;
		}

		[XmlElement("packing_amount")]
		public string PackingAmount
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

		[XmlArray("pay_channels")]
		[XmlArrayItem("pos_bill_pay_channel")]
		public List<PosBillPayChannel> PayChannels
		{
			get;
			set;
		}

		[XmlElement("people_num")]
		public string PeopleNum
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

		[XmlElement("service_amount")]
		public string ServiceAmount
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("table_time")]
		public string TableTime
		{
			get;
			set;
		}

		[XmlElement("take_no")]
		public string TakeNo
		{
			get;
			set;
		}

		[XmlElement("take_style")]
		public string TakeStyle
		{
			get;
			set;
		}

		[XmlElement("trade_amount")]
		public string TradeAmount
		{
			get;
			set;
		}

		[XmlElement("user_mobile")]
		public string UserMobile
		{
			get;
			set;
		}
	}
}
