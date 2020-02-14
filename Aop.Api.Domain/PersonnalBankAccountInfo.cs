using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PersonnalBankAccountInfo : AopObject
	{
		[XmlElement("personal_bank_account_mobile")]
		public string PersonalBankAccountMobile
		{
			get;
			set;
		}

		[XmlElement("personal_bank_card_no")]
		public string PersonalBankCardNo
		{
			get;
			set;
		}

		[XmlElement("personal_bank_holder_certno")]
		public string PersonalBankHolderCertno
		{
			get;
			set;
		}

		[XmlElement("personal_bank_holder_name")]
		public string PersonalBankHolderName
		{
			get;
			set;
		}
	}
}
