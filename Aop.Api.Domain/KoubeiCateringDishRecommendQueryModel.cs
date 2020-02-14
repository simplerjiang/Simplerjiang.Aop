using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishRecommendQueryModel : AopObject
	{
		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlArray("dish_list")]
		[XmlArrayItem("dishes")]
		public List<Dishes> DishList
		{
			get;
			set;
		}

		[XmlElement("merchent_pid")]
		public string MerchentPid
		{
			get;
			set;
		}

		[XmlElement("people")]
		public string People
		{
			get;
			set;
		}

		[XmlElement("per_price")]
		public string PerPrice
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

		[XmlElement("type")]
		public string Type
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
