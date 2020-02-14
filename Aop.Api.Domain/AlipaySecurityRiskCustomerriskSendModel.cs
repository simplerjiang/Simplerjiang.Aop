using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskCustomerriskSendModel : AopObject
	{
		[XmlElement("bank_card_no")]
		public string BankCardNo
		{
			get;
			set;
		}

		[XmlElement("business_license_no")]
		public string BusinessLicenseNo
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("email_address")]
		public string EmailAddress
		{
			get;
			set;
		}

		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("merch_name")]
		public string MerchName
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("mobile_ip")]
		public string MobileIp
		{
			get;
			set;
		}

		[XmlElement("order_ip")]
		public string OrderIp
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("plat_account")]
		public string PlatAccount
		{
			get;
			set;
		}

		[XmlElement("process_code")]
		public string ProcessCode
		{
			get;
			set;
		}

		[XmlElement("smid")]
		public string Smid
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
	}
}
