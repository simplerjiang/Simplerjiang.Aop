using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherConfirmModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("biz_info_ext")]
		public string BizInfoExt
		{
			get;
			set;
		}

		[XmlElement("biz_request_id")]
		public string BizRequestId
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
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

		[XmlElement("exchange_ids")]
		public string ExchangeIds
		{
			get;
			set;
		}

		[XmlElement("operate_time")]
		public string OperateTime
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
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

		[XmlElement("seller_id")]
		public string SellerId
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

		[XmlElement("ticket_no")]
		public string TicketNo
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
