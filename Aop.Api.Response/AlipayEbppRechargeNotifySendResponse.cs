using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppRechargeNotifySendResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
