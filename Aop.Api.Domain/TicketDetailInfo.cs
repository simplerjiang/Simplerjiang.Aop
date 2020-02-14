using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TicketDetailInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("end_station")]
		public string EndStation
		{
			get;
			set;
		}

		[XmlElement("end_station_name")]
		public string EndStationName
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

		[XmlElement("start_station")]
		public string StartStation
		{
			get;
			set;
		}

		[XmlElement("start_station_name")]
		public string StartStationName
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("ticket_price")]
		public string TicketPrice
		{
			get;
			set;
		}

		[XmlElement("ticket_type")]
		public string TicketType
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
