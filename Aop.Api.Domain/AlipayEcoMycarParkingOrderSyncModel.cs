using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingOrderSyncModel : AopObject
	{
		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}

		[XmlElement("card_number")]
		public string CardNumber
		{
			get;
			set;
		}

		[XmlElement("in_duration")]
		public string InDuration
		{
			get;
			set;
		}

		[XmlElement("in_time")]
		public string InTime
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

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("order_time")]
		public string OrderTime
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
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

		[XmlElement("parking_id")]
		public string ParkingId
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

		[XmlElement("pay_money")]
		public string PayMoney
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
