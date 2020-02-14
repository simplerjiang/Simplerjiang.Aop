using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserPointAuthbaseSendResponse : AopResponse
	{
		[XmlElement("send_point")]
		public long SendPoint
		{
			get;
			set;
		}
	}
}
