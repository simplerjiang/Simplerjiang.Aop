using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceTitleModel : AopObject
	{
		[XmlElement("is_default")]
		public bool IsDefault
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}

		[XmlElement("open_bank_account")]
		public string OpenBankAccount
		{
			get;
			set;
		}

		[XmlElement("open_bank_name")]
		public string OpenBankName
		{
			get;
			set;
		}

		[XmlElement("tax_register_no")]
		public string TaxRegisterNo
		{
			get;
			set;
		}

		[XmlElement("tele_phone_no")]
		public string TelePhoneNo
		{
			get;
			set;
		}

		[XmlElement("title_name")]
		public string TitleName
		{
			get;
			set;
		}

		[XmlElement("title_type")]
		public string TitleType
		{
			get;
			set;
		}

		[XmlElement("user_address")]
		public string UserAddress
		{
			get;
			set;
		}

		[XmlElement("user_email")]
		public string UserEmail
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

		[XmlElement("user_mobile")]
		public string UserMobile
		{
			get;
			set;
		}
	}
}
