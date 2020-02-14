using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionChannelModifyModel : AopObject
	{
		[XmlArray("channels")]
		[XmlArrayItem("kb_advert_modify_channel_request")]
		public List<KbAdvertModifyChannelRequest> Channels
		{
			get;
			set;
		}
	}
}
