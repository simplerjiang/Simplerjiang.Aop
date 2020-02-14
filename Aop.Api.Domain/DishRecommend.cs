using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DishRecommend : AopObject
	{
		[XmlElement("buy_posibility")]
		public string BuyPosibility
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
		public string DishNum
		{
			get;
			set;
		}

		[XmlElement("dish_skuid")]
		public string DishSkuid
		{
			get;
			set;
		}

		[XmlElement("info_code")]
		public string InfoCode
		{
			get;
			set;
		}
	}
}
