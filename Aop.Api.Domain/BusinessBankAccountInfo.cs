using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BusinessBankAccountInfo : AopObject
	{
		[XmlElement("business_bank_account_name")]
		public string BusinessBankAccountName
		{
			get;
			set;
		}

		[XmlElement("business_bank_card_no")]
		public string BusinessBankCardNo
		{
			get;
			set;
		}

		[XmlElement("business_bank_name")]
		public string BusinessBankName
		{
			get;
			set;
		}

		[XmlElement("business_bank_sub")]
		public string BusinessBankSub
		{
			get;
			set;
		}
	}
}
