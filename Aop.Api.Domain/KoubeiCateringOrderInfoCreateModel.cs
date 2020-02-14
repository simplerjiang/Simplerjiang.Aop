using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderInfoCreateModel : AopObject
	{
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

		[XmlElement("org_dv_sn")]
		public string OrgDvSn
		{
			get;
			set;
		}

		[XmlElement("org_out_biz_no")]
		public string OrgOutBizNo
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

		[XmlElement("people_num")]
		public long PeopleNum
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
	}
}
