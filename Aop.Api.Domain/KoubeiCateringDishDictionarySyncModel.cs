using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishDictionarySyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("kb_dish_dictionary")]
		public KbdishDictionary KbDishDictionary
		{
			get;
			set;
		}

		[XmlElement("syn_type")]
		public string SynType
		{
			get;
			set;
		}
	}
}
