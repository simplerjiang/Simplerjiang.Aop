using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbPosOrderDishDetail : AopObject
	{
		[XmlElement("change_price")]
		public string ChangePrice
		{
			get;
			set;
		}

		[XmlElement("change_reason")]
		public string ChangeReason
		{
			get;
			set;
		}

		[XmlElement("cook_id")]
		public string CookId
		{
			get;
			set;
		}

		[XmlElement("cook_version")]
		public string CookVersion
		{
			get;
			set;
		}

		[XmlElement("discountable")]
		public bool Discountable
		{
			get;
			set;
		}

		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlElement("dish_name")]
		public string DishName
		{
			get;
			set;
		}

		[XmlElement("dish_num")]
		public long DishNum
		{
			get;
			set;
		}

		[XmlElement("dish_unit")]
		public string DishUnit
		{
			get;
			set;
		}

		[XmlElement("dish_version")]
		public long DishVersion
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

		[XmlElement("has_change")]
		public bool HasChange
		{
			get;
			set;
		}

		[XmlElement("main_flag")]
		public bool MainFlag
		{
			get;
			set;
		}

		[XmlElement("main_out_detail_no")]
		public string MainOutDetailNo
		{
			get;
			set;
		}

		[XmlElement("make_status")]
		public string MakeStatus
		{
			get;
			set;
		}

		[XmlElement("member_price")]
		public string MemberPrice
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

		[XmlElement("operator")]
		public string Operator
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

		[XmlElement("out_detail_no")]
		public string OutDetailNo
		{
			get;
			set;
		}

		[XmlElement("practice_info")]
		public string PracticeInfo
		{
			get;
			set;
		}

		[XmlElement("practice_price")]
		public string PracticePrice
		{
			get;
			set;
		}

		[XmlElement("refund_reason")]
		public string RefundReason
		{
			get;
			set;
		}

		[XmlElement("refund_time")]
		public string RefundTime
		{
			get;
			set;
		}

		[XmlElement("remind_time")]
		public long RemindTime
		{
			get;
			set;
		}

		[XmlElement("sell_price")]
		public string SellPrice
		{
			get;
			set;
		}

		[XmlElement("sku_id")]
		public string SkuId
		{
			get;
			set;
		}

		[XmlElement("sort")]
		public long Sort
		{
			get;
			set;
		}

		[XmlElement("spec_name")]
		public string SpecName
		{
			get;
			set;
		}

		[XmlElement("user_identity")]
		public string UserIdentity
		{
			get;
			set;
		}

		[XmlElement("wake_status")]
		public string WakeStatus
		{
			get;
			set;
		}
	}
}
