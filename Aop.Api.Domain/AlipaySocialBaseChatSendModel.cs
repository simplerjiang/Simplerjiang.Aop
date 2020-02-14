using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatSendModel : AopObject
	{
		[XmlElement("biz_memo")]
		public string BizMemo
		{
			get;
			set;
		}

		[XmlElement("client_msg_id")]
		public string ClientMsgId
		{
			get;
			set;
		}

		[XmlElement("link")]
		public string Link
		{
			get;
			set;
		}

		[XmlElement("receiver_id")]
		public string ReceiverId
		{
			get;
			set;
		}

		[XmlElement("receiver_usertype")]
		public string ReceiverUsertype
		{
			get;
			set;
		}

		[XmlElement("template_data")]
		public string TemplateData
		{
			get;
			set;
		}

		[XmlElement("template_type")]
		public string TemplateType
		{
			get;
			set;
		}
	}
}
