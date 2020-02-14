using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatMsgSendResponse : AopResponse
	{
		[XmlElement("msg_index")]
		public string MsgIndex
		{
			get;
			set;
		}
	}
}
