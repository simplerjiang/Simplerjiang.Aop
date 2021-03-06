using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageGroupSendModel : AopObject
	{
		[XmlArray("articles")]
		[XmlArrayItem("article")]
		public List<Article> Articles
		{
			get;
			set;
		}

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("image")]
		public Image Image
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
	}
}
