using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ServiceOrderInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("gmt_payment")]
		public string GmtPayment
		{
			get;
			set;
		}

		[XmlElement("gmt_refund")]
		public string GmtRefund
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("out_service_id")]
		public string OutServiceId
		{
			get;
			set;
		}

		[XmlElement("out_sku_id")]
		public string OutSkuId
		{
			get;
			set;
		}

		[XmlArray("out_sp_id")]
		[XmlArrayItem("string")]
		public List<string> OutSpId
		{
			get;
			set;
		}

		[XmlElement("payment_amount")]
		public string PaymentAmount
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
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

		[XmlElement("real_amount")]
		public string RealAmount
		{
			get;
			set;
		}

		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlElement("service_id")]
		public string ServiceId
		{
			get;
			set;
		}

		[XmlElement("service_order_no")]
		public string ServiceOrderNo
		{
			get;
			set;
		}

		[XmlElement("sku_id")]
		public string SkuId
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

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}
	}
}
