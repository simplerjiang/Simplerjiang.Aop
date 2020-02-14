using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatMsgSendModel : AopObject
	{
		[XmlElement("biz_memo")]
		public string BizMemo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
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

		[XmlElement("hidden_side")]
		public string HiddenSide
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

		[XmlElement("push_str")]
		public string PushStr
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

		[XmlElement("template_code")]
		public string TemplateCode
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
	}
}
