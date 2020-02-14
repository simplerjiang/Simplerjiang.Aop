using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MiniAppCategoryInfo : AopObject
	{
		[XmlElement("first_category_id")]
		public string FirstCategoryId
		{
			get;
			set;
		}

		[XmlElement("first_category_name")]
		public string FirstCategoryName
		{
			get;
			set;
		}

		[XmlElement("second_category_id")]
		public string SecondCategoryId
		{
			get;
			set;
		}

		[XmlElement("second_category_name")]
		public string SecondCategoryName
		{
			get;
			set;
		}
	}
}
