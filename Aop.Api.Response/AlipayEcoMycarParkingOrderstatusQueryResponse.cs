using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingOrderstatusQueryResponse : AopResponse
	{
		[XmlElement("alipay_order_id")]
		public string AlipayOrderId
		{
			get;
			set;
		}

		[XmlElement("car_order_id")]
		public string CarOrderId
		{
			get;
			set;
		}

		[XmlElement("equipment_order_id")]
		public string EquipmentOrderId
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

		[XmlElement("pay_status")]
		public string PayStatus
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
