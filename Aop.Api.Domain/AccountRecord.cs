using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccountRecord : AopObject
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("business_type")]
		public string BusinessType
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("in_amount")]
		public string InAmount
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

		[XmlElement("merchant_order_no")]
		public string MerchantOrderNo
		{
			get;
			set;
		}

		[XmlElement("opt_user_id")]
		public string OptUserId
		{
			get;
			set;
		}

		[XmlElement("out_amount")]
		public string OutAmount
		{
			get;
			set;
		}

		[XmlElement("self_user_id")]
		public string SelfUserId
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
