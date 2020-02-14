using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineTrade : AopObject
	{
		[XmlElement("actual_order_time")]
		public string ActualOrderTime
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("order_biz_context")]
		public string OrderBizContext
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

		[XmlArray("records")]
		[XmlArrayItem("string")]
		public List<string> Records
		{
			get;
			set;
		}

		[XmlElement("seller_login_name")]
		public string SellerLoginName
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
