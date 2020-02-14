using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherUploadModel : AopObject
	{
		[XmlElement("biz_info_ext")]
		public string BizInfoExt
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

		[XmlElement("ticket_no")]
		public string TicketNo
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
