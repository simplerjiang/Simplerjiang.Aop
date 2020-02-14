using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderInfoModifyModel : AopObject
	{
		[XmlElement("action")]
		public string Action
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

		[XmlElement("take_no")]
		public string TakeNo
		{
			get;
			set;
		}
	}
}
