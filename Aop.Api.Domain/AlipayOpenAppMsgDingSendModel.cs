using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppMsgDingSendModel : AopObject
	{
		[XmlElement("agent_id")]
		public string AgentId
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("goto_url")]
		public string GotoUrl
		{
			get;
			set;
		}

		[XmlElement("image_url")]
		public string ImageUrl
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

		[XmlElement("receiver")]
		public string Receiver
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlArray("user_ids")]
		[XmlArrayItem("string")]
		public List<string> UserIds
		{
			get;
			set;
		}
	}
}
