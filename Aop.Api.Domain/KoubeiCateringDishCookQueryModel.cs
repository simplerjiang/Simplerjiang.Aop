using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishCookQueryModel : AopObject
	{
		[XmlElement("cook_id")]
		public string CookId
		{
			get;
			set;
		}

		[XmlElement("cook_status")]
		public string CookStatus
		{
			get;
			set;
		}

		[XmlElement("detail_catetory_big_id")]
		public string DetailCatetoryBigId
		{
			get;
			set;
		}

		[XmlElement("detail_catetory_small_id")]
		public string DetailCatetorySmallId
		{
			get;
			set;
		}

		[XmlElement("detail_status")]
		public string DetailStatus
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

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}
	}
}
