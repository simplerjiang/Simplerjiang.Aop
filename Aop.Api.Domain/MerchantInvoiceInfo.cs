using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantInvoiceInfo : AopObject
	{
		[XmlElement("accept_electronic")]
		public bool AcceptElectronic
		{
			get;
			set;
		}

		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("auto_invoice")]
		public bool AutoInvoice
		{
			get;
			set;
		}

		[XmlElement("bank_account")]
		public string BankAccount
		{
			get;
			set;
		}

		[XmlElement("bank_name")]
		public string BankName
		{
			get;
			set;
		}

		[XmlElement("mail_address")]
		public AddressInfo MailAddress
		{
			get;
			set;
		}

		[XmlElement("mail_name")]
		public string MailName
		{
			get;
			set;
		}

		[XmlElement("mail_telephone")]
		public string MailTelephone
		{
			get;
			set;
		}

		[XmlElement("tax_no")]
		public string TaxNo
		{
			get;
			set;
		}

		[XmlElement("tax_payer_qualification")]
		public string TaxPayerQualification
		{
			get;
			set;
		}

		[XmlElement("tax_payer_valid")]
		public string TaxPayerValid
		{
			get;
			set;
		}

		[XmlElement("telephone")]
		public string Telephone
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
