using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppCommonNotifySendResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
