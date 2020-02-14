using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceTitleOpenModel : AopObject
	{
		[XmlElement("payer_address_tel")]
		public string PayerAddressTel
		{
			get;
			set;
		}

		[XmlElement("payer_bank_name_account")]
		public string PayerBankNameAccount
		{
			get;
			set;
		}

		[XmlElement("payer_register_no")]
		public string PayerRegisterNo
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
	}
}
