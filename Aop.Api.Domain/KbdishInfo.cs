using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishInfo : AopObject
	{
		[XmlElement("catetory_big_id")]
		public string CatetoryBigId
		{
			get;
			set;
		}

		[XmlElement("catetory_small_id")]
		public string CatetorySmallId
		{
			get;
			set;
		}

		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlElement("cur_price_flag")]
		public string CurPriceFlag
		{
			get;
			set;
		}

		[XmlElement("default_in_carts")]
		public string DefaultInCarts
		{
			get;
			set;
		}

		[XmlElement("default_in_carts_detail")]
		public string DefaultInCartsDetail
		{
			get;
			set;
		}

		[XmlElement("dish_cuisine")]
		public string DishCuisine
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

		[XmlElement("dish_img")]
		public string DishImg
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

		[XmlArray("dish_practice_list")]
		[XmlArrayItem("kbdish_practice_info")]
		public List<KbdishPracticeInfo> DishPracticeList
		{
			get;
			set;
		}

		[XmlArray("dish_sku_list")]
		[XmlArrayItem("kbdish_sku_info")]
		public List<KbdishSkuInfo> DishSkuList
		{
			get;
			set;
		}

		[XmlElement("dish_version")]
		public string DishVersion
		{
			get;
			set;
		}

		[XmlElement("en_remember_code")]
		public string EnRememberCode
		{
			get;
			set;
		}

		[XmlElement("ext_content")]
		public string ExtContent
		{
			get;
			set;
		}

		[XmlElement("goods_id")]
		public string GoodsId
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

		[XmlElement("min_serving")]
		public string MinServing
		{
			get;
			set;
		}

		[XmlElement("mini_add_num")]
		public string MiniAddNum
		{
			get;
			set;
		}

		[XmlElement("nb_remember_code")]
		public string NbRememberCode
		{
			get;
			set;
		}

		[XmlElement("not_count_threshold")]
		public string NotCountThreshold
		{
			get;
			set;
		}

		[XmlElement("out_dish_id")]
		public string OutDishId
		{
			get;
			set;
		}

		[XmlElement("remarks")]
		public string Remarks
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("tags")]
		public string Tags
		{
			get;
			set;
		}

		[XmlElement("type_big")]
		public string TypeBig
		{
			get;
			set;
		}

		[XmlElement("type_small")]
		public string TypeSmall
		{
			get;
			set;
		}

		[XmlElement("unit_id")]
		public string UnitId
		{
			get;
			set;
		}

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
