using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionChannelModifyResponse : AopResponse
	{
		[XmlArray("channel_response")]
		[XmlArrayItem("kb_advert_channel_response")]
		public List<KbAdvertChannelResponse> ChannelResponse
		{
			get;
			set;
		}
	}
}
