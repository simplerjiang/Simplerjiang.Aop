using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineProviderDishQueryModel : AopObject
	{
		[XmlElement("dish_type_name")]
		public string DishTypeName
		{
			get;
			set;
		}

		[XmlElement("order_by")]
		public string OrderBy
		{
			get;
			set;
		}

		[XmlElement("outer_dish_id")]
		public string OuterDishId
		{
			get;
			set;
		}

		[XmlElement("page")]
		public long Page
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
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
	}
}
