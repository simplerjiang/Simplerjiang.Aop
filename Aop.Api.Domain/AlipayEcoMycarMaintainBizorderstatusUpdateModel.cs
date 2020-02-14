using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMaintainBizorderstatusUpdateModel : AopObject
	{
		[XmlElement("alipay_trade_no")]
		public string AlipayTradeNo
		{
			get;
			set;
		}

		[XmlElement("biz_status_txt")]
		public string BizStatusTxt
		{
			get;
			set;
		}

		[XmlElement("industry_code")]
		public string IndustryCode
		{
			get;
			set;
		}

		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("logistics_company")]
		public string LogisticsCompany
		{
			get;
			set;
		}

		[XmlElement("logistics_no")]
		public string LogisticsNo
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

		[XmlElement("pay_account")]
		public string PayAccount
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

		[XmlElement("sender_addr")]
		public string SenderAddr
		{
			get;
			set;
		}
	}
}
