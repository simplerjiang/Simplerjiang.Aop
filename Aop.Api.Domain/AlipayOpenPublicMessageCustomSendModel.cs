using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageCustomSendModel : AopObject
	{
		[XmlArray("articles")]
		[XmlArrayItem("article")]
		public List<Article> Articles
		{
			get;
			set;
		}

		[XmlElement("chat")]
		public string Chat
		{
			get;
			set;
		}

		[XmlElement("event_type")]
		public string EventType
		{
			get;
			set;
		}

		[XmlElement("msg_type")]
		public string MsgType
		{
			get;
			set;
		}

		[XmlElement("text")]
		public Text Text
		{
			get;
			set;
		}

		[XmlElement("to_user_id")]
		public string ToUserId
		{
			get;
			set;
		}
	}
}
