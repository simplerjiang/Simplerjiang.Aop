using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeFastpayEteDidiPayModel : AopObject
	{
		[XmlElement("body")]
		public string Body
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("login_passwd")]
		public string LoginPasswd
		{
			get;
			set;
		}

		[XmlElement("mc_notify_url")]
		public string McNotifyUrl
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

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("pay_passwd")]
		public string PayPasswd
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
