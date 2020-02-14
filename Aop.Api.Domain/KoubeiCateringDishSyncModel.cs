using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishSyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("kb_dish_info")]
		public KbdishInfo KbDishInfo
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
