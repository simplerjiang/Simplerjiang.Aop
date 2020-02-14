using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OrderDetail : AopObject
	{
		[XmlElement("app_id")]
		public string AppId
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

		[XmlArray("goods_detail")]
		[XmlArrayItem("goods_detail")]
		public List<GoodsDetail> GoodsDetail
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

		[XmlElement("passback_params")]
		public string PassbackParams
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

		[XmlElement("show_url")]
		public string ShowUrl
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

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
