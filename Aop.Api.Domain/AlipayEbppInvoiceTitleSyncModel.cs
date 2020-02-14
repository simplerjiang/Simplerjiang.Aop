using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTitleSyncModel : AopObject
	{
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

		[XmlElement("title_name")]
		public string TitleName
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
