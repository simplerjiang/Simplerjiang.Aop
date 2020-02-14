using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishQueryModel : AopObject
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

		[XmlElement("dish_name")]
		public string DishName
		{
			get;
			set;
		}

		[XmlElement("dish_status")]
		public string DishStatus
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

		[XmlElement("merchant_id")]
		public string MerchantId
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

		[XmlElement("sku_id")]
		public string SkuId
		{
			get;
			set;
		}
	}
}
