using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertModifyChannelRequest : AopObject
	{
		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
