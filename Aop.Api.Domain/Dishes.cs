using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Dishes : AopObject
	{
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

		[XmlElement("dish_price")]
		public string DishPrice
		{
			get;
			set;
		}

		[XmlElement("dish_real_price")]
		public string DishRealPrice
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
	}
}
