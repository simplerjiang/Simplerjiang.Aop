using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeMsgSendResponse : AopResponse
	{
		[XmlElement("alipay_msg_id")]
		public string AlipayMsgId
		{
			get;
			set;
		}
	}
}
