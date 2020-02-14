using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingOrderPayModel : AopObject
	{
		[XmlElement("agent_id")]
		public string AgentId
		{
			get;
			set;
		}

		[XmlElement("body")]
		public string Body
		{
			get;
			set;
		}

		[XmlElement("car_number")]
		public string CarNumber
		{
			get;
			set;
		}

		[XmlElement("car_number_color")]
		public string CarNumberColor
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

		[XmlElement("out_trade_no")]
		public string OutTradeNo
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

		[XmlElement("seller_id")]
		public string SellerId
		{
			get;
			set;
		}

		[XmlElement("seller_logon_id")]
		public string SellerLogonId
		{
			get;
			set;
		}

		[XmlElement("subject")]
		public string Subject
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
	}
}
