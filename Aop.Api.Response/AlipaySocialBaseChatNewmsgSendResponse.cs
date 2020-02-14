using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseChatNewmsgSendResponse : AopResponse
	{
		[XmlElement("msg_index")]
		public string MsgIndex
		{
			get;
			set;
		}
	}
}
