using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishAreaSyncModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("kb_dish_area")]
		public KbdishAreaInfo KbDishArea
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
