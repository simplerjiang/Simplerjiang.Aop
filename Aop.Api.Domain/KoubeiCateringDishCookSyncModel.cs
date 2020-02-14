using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishCookSyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("kb_dish_cook")]
		public KbdishCookInfo KbDishCook
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
