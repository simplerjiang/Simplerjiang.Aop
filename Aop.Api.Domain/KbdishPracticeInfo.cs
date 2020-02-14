using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishPracticeInfo : AopObject
	{
		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlElement("increase_mode")]
		public string IncreaseMode
		{
			get;
			set;
		}

		[XmlElement("increase_price")]
		public string IncreasePrice
		{
			get;
			set;
		}

		[XmlElement("practice_name")]
		public string PracticeName
		{
			get;
			set;
		}
	}
}
