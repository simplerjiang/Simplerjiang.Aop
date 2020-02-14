using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantOrderCreditCreateModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("deposit")]
		public string Deposit
		{
			get;
			set;
		}

		[XmlElement("from_channel")]
		public string FromChannel
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("order_process_url")]
		public string OrderProcessUrl
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

		[XmlElement("overdue_time")]
		public string OverdueTime
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
	}
}
