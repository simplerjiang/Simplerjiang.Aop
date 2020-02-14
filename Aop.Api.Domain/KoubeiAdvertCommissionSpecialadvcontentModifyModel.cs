using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionSpecialadvcontentModifyModel : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
		{
			get;
			set;
		}

		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlArray("content_list")]
		[XmlArrayItem("kb_advert_special_adv_content_request")]
		public List<KbAdvertSpecialAdvContentRequest> ContentList
		{
			get;
			set;
		}

		[XmlElement("modify_type")]
		public string ModifyType
		{
			get;
			set;
		}
	}
}
