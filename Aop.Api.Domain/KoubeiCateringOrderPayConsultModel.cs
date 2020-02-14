using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderPayConsultModel : AopObject
	{
		[XmlElement("apdid_token")]
		public string ApdidToken
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

		[XmlElement("member_flag")]
		public bool MemberFlag
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

		[XmlElement("request_id")]
		public string RequestId
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

		[XmlElement("total_amount")]
		public string TotalAmount
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
