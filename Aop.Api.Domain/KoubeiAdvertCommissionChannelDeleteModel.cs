using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionChannelDeleteModel : AopObject
	{
		[XmlArray("channel_ids")]
		[XmlArrayItem("string")]
		public List<string> ChannelIds
		{
			get;
			set;
		}
	}
}
