using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionChannelCreateModel : AopObject
	{
		[XmlArray("channels")]
		[XmlArrayItem("kb_advert_add_channel_request")]
		public List<KbAdvertAddChannelRequest> Channels
		{
			get;
			set;
		}
	}
}
