using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EntertainmentOrderInfo : AopObject
	{
		[XmlElement("alipay_trade_no")]
		public string AlipayTradeNo
		{
			get;
			set;
		}

		[XmlElement("alipay_uid")]
		public string AlipayUid
		{
			get;
			set;
		}

		[XmlElement("complete_time")]
		public long CompleteTime
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public long CreateTime
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("goods_code")]
		public string GoodsCode
		{
			get;
			set;
		}

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlElement("isv_code")]
		public string IsvCode
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
		public long OrderStatus
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public long PayTime
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("product_name")]
		public string ProductName
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("total_payment")]
		public string TotalPayment
		{
			get;
			set;
		}

		[XmlElement("unit_price")]
		public string UnitPrice
		{
			get;
			set;
		}

		[XmlElement("user_account")]
		public string UserAccount
		{
			get;
			set;
		}
	}
}
