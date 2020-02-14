using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeTicketTicketcodeCancelModel : AopObject
	{
		[XmlElement("code_type")]
		public string CodeType
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

		[XmlElement("quantity")]
		public string Quantity
		{
			get;
			set;
		}

		[XmlElement("request_biz_no")]
		public string RequestBizNo
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
