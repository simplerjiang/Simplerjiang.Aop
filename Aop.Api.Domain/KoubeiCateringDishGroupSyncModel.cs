using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishGroupSyncModel : AopObject
	{
		[XmlElement("kb_dish_group")]
		public KbdishGroupInfo KbDishGroup
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
