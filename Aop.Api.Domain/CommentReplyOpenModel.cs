using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CommentReplyOpenModel : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("reply_publish_time")]
		public string ReplyPublishTime
		{
			get;
			set;
		}
	}
}
