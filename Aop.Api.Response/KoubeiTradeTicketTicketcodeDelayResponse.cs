using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeTicketTicketcodeDelayResponse : AopResponse
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
