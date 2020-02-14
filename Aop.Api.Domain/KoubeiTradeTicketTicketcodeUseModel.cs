using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiTradeTicketTicketcodeUseModel : AopObject
	{
		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("gmt_biz")]
		public string GmtBiz
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

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_type")]
		public string ShopType
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
