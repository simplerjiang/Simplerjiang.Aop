using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeTicketTicketcodeQueryModel : AopObject
	{
		[XmlElement("shop_id")]
		public string ShopId
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
