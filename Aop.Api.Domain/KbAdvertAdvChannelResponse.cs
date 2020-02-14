using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertAdvChannelResponse : AopObject
	{
		[XmlArray("adv_content_list")]
		[XmlArrayItem("kb_advert_adv_content_response")]
		public List<KbAdvertAdvContentResponse> AdvContentList
		{
			get;
			set;
		}

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

		[XmlElement("channel_name")]
		public string ChannelName
		{
			get;
			set;
		}

		[XmlElement("channel_type")]
		public string ChannelType
		{
			get;
			set;
		}
	}
}
