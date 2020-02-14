using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceLotteryPresentSendResponse : AopResponse
	{
		[XmlElement("send_result")]
		public bool SendResult
		{
			get;
			set;
		}
	}
}
