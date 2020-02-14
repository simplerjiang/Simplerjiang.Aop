using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderBillApplyModel : AopObject
	{
		[XmlElement("bill_amount")]
		public string BillAmount
		{
			get;
			set;
		}

		[XmlArray("discount_details")]
		[XmlArrayItem("pos_discount_detail")]
		public List<PosDiscountDetail> DiscountDetails
		{
			get;
			set;
		}

		[XmlArray("dish_details")]
		[XmlArrayItem("kb_pos_bill_dish_detail")]
		public List<KbPosBillDishDetail> DishDetails
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
		public bool MemberFlag
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

		[XmlElement("people_list")]
		public string PeopleList
		{
			get;
			set;
		}

		[XmlElement("pos_order_key")]
		public PosOrderKey PosOrderKey
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

		[XmlElement("settle_time")]
		public string SettleTime
		{
			get;
			set;
		}
	}
}
