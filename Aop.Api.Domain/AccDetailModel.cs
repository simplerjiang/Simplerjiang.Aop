using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccDetailModel : AopObject
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}

		[XmlElement("cert_info")]
		public CertInfo CertInfo
		{
			get;
			set;
		}

		[XmlElement("detail_no")]
		public string DetailNo
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("exchange_rate")]
		public ExchangeRate ExchangeRate
		{
			get;
			set;
		}

		[XmlElement("need_retry")]
		public string NeedRetry
		{
			get;
			set;
		}

		[XmlElement("payee_info")]
		public AccPayeeInfo PayeeInfo
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

		[XmlElement("payment_currency")]
		public string PaymentCurrency
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("settlement_amount")]
		public string SettlementAmount
		{
			get;
			set;
		}

		[XmlElement("settlement_currency")]
		public string SettlementCurrency
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

		[XmlElement("trans_amount")]
		public string TransAmount
		{
			get;
			set;
		}

		[XmlElement("trans_currency")]
		public string TransCurrency
		{
			get;
			set;
		}
	}
}
