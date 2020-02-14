using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceTitleApplyOpenModel : AopObject
	{
		[XmlElement("payer_address")]
		public string PayerAddress
		{
			get;
			set;
		}

		[XmlElement("payer_bank_account")]
		public string PayerBankAccount
		{
			get;
			set;
		}

		[XmlElement("payer_bank_name")]
		public string PayerBankName
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

		[XmlElement("payer_tel")]
		public string PayerTel
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
