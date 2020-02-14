using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherGenerateModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("site_begin")]
		public string SiteBegin
		{
			get;
			set;
		}

		[XmlElement("site_end")]
		public string SiteEnd
		{
			get;
			set;
		}

		[XmlElement("ticket_num")]
		public string TicketNum
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

		[XmlElement("total_fee")]
		public string TotalFee
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
