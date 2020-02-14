using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MyBkAccountVO : AopObject
	{
		[XmlElement("account_ext_no")]
		public string AccountExtNo
		{
			get;
			set;
		}

		[XmlElement("account_fip_branch_code")]
		public string AccountFipBranchCode
		{
			get;
			set;
		}

		[XmlElement("account_fip_code")]
		public string AccountFipCode
		{
			get;
			set;
		}

		[XmlElement("account_fip_name")]
		public string AccountFipName
		{
			get;
			set;
		}

		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("available")]
		public string Available
		{
			get;
			set;
		}

		[XmlElement("bank_card_category")]
		public string BankCardCategory
		{
			get;
			set;
		}

		[XmlElement("card_holder_name")]
		public string CardHolderName
		{
			get;
			set;
		}

		[XmlElement("grant_channel")]
		public string GrantChannel
		{
			get;
			set;
		}

		[XmlElement("refuse_code")]
		public string RefuseCode
		{
			get;
			set;
		}
	}
}
