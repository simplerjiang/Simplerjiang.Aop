using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditAntifraudRiskListModel : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("bank_card")]
		public string BankCard
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

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("imei")]
		public string Imei
		{
			get;
			set;
		}

		[XmlElement("ip")]
		public string Ip
		{
			get;
			set;
		}

		[XmlElement("mac")]
		public string Mac
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

		[XmlElement("name")]
		public string Name
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

		[XmlElement("transaction_id")]
		public string TransactionId
		{
			get;
			set;
		}

		[XmlElement("wifimac")]
		public string Wifimac
		{
			get;
			set;
		}
	}
}
