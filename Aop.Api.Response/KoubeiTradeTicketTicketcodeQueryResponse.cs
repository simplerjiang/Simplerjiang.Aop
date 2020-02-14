using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeTicketTicketcodeQueryResponse : AopResponse
	{
		[XmlElement("available_quantity")]
		public string AvailableQuantity
		{
			get;
			set;
		}

		[XmlElement("current_price")]
		public string CurrentPrice
		{
			get;
			set;
		}

		[XmlElement("effect_date")]
		public string EffectDate
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
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

		[XmlElement("original_price")]
		public string OriginalPrice
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

		[XmlElement("ticket_status")]
		public string TicketStatus
		{
			get;
			set;
		}

		[XmlElement("ticket_status_desc")]
		public string TicketStatusDesc
		{
			get;
			set;
		}

		[XmlArray("ticket_trans_info_list")]
		[XmlArrayItem("ticket_trans_info")]
		public List<TicketTransInfo> TicketTransInfoList
		{
			get;
			set;
		}

		[XmlElement("time_cards")]
		public string TimeCards
		{
			get;
			set;
		}

		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
