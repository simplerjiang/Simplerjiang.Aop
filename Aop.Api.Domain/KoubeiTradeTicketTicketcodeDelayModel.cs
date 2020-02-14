using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeTicketTicketcodeDelayModel : AopObject
	{
		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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

		[XmlElement("ticket_code")]
		public string TicketCode
		{
			get;
			set;
		}
	}
}
