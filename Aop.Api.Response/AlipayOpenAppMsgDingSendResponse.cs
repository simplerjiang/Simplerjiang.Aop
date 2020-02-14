using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppMsgDingSendResponse : AopResponse
	{
		[XmlElement("msg_id")]
		public string MsgId
		{
			get;
			set;
		}
	}
}
