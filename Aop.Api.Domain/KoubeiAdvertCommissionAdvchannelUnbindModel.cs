using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionAdvchannelUnbindModel : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
		{
			get;
			set;
		}

		[XmlArray("channel_id_list")]
		[XmlArrayItem("string")]
		public List<string> ChannelIdList
		{
			get;
			set;
		}
	}
}
