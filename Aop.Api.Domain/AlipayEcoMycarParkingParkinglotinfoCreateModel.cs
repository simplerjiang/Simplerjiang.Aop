using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingParkinglotinfoCreateModel : AopObject
	{
		[XmlElement("agent_id")]
		public string AgentId
		{
			get;
			set;
		}

		[XmlElement("city_id")]
		public string CityId
		{
			get;
			set;
		}

		[XmlElement("contact_alipay")]
		public string ContactAlipay
		{
			get;
			set;
		}

		[XmlElement("contact_emali")]
		public string ContactEmali
		{
			get;
			set;
		}

		[XmlElement("contact_mobile")]
		public string ContactMobile
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("contact_tel")]
		public string ContactTel
		{
			get;
			set;
		}

		[XmlElement("contact_weixin")]
		public string ContactWeixin
		{
			get;
			set;
		}

		[XmlElement("equipment_name")]
		public string EquipmentName
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("out_parking_id")]
		public string OutParkingId
		{
			get;
			set;
		}

		[XmlElement("parking_address")]
		public string ParkingAddress
		{
			get;
			set;
		}

		[XmlElement("parking_end_time")]
		public string ParkingEndTime
		{
			get;
			set;
		}

		[XmlElement("parking_fee_description")]
		public string ParkingFeeDescription
		{
			get;
			set;
		}

		[XmlElement("parking_lot_type")]
		public string ParkingLotType
		{
			get;
			set;
		}

		[XmlElement("parking_mobile")]
		public string ParkingMobile
		{
			get;
			set;
		}

		[XmlElement("parking_name")]
		public string ParkingName
		{
			get;
			set;
		}

		[XmlElement("parking_number")]
		public string ParkingNumber
		{
			get;
			set;
		}

		[XmlElement("parking_poiid")]
		public string ParkingPoiid
		{
			get;
			set;
		}

		[XmlElement("parking_start_time")]
		public string ParkingStartTime
		{
			get;
			set;
		}

		[XmlElement("parking_type")]
		public string ParkingType
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public string PayType
		{
			get;
			set;
		}

		[XmlElement("payment_mode")]
		public string PaymentMode
		{
			get;
			set;
		}

		[XmlElement("shopingmall_id")]
		public string ShopingmallId
		{
			get;
			set;
		}

		[XmlElement("time_out")]
		public string TimeOut
		{
			get;
			set;
		}
	}
}
