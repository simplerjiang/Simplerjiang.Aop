using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IsvShopDishModel : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("dish_type_id")]
		public string DishTypeId
		{
			get;
			set;
		}

		[XmlElement("dish_type_name")]
		public string DishTypeName
		{
			get;
			set;
		}

		[XmlElement("good_level")]
		public string GoodLevel
		{
			get;
			set;
		}

		[XmlElement("merchant_sold_cnt_seven_d")]
		public long MerchantSoldCntSevenD
		{
			get;
			set;
		}

		[XmlElement("merchant_sold_cnt_thirty_d")]
		public long MerchantSoldCntThirtyD
		{
			get;
			set;
		}

		[XmlElement("merchant_sold_reusercnt_thirty_d")]
		public long MerchantSoldReusercntThirtyD
		{
			get;
			set;
		}

		[XmlElement("merchant_sold_usercnt_thirty_d")]
		public long MerchantSoldUsercntThirtyD
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
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

		[XmlElement("pict")]
		public string Pict
		{
			get;
			set;
		}

		[XmlElement("platform")]
		public string Platform
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public long Quantity
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

		[XmlElement("sold_cnt_seven_d")]
		public long SoldCntSevenD
		{
			get;
			set;
		}

		[XmlElement("sold_cnt_thirty_d")]
		public long SoldCntThirtyD
		{
			get;
			set;
		}

		[XmlElement("sold_reusercnt_thirty_d")]
		public long SoldReusercntThirtyD
		{
			get;
			set;
		}

		[XmlElement("sold_usercnt_thirty_d")]
		public long SoldUsercntThirtyD
		{
			get;
			set;
		}

		[XmlArray("sort_col")]
		[XmlArrayItem("number")]
		public List<long> SortCol
		{
			get;
			set;
		}

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}
	}
}
