using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneProdPaymentAccountInfo : AopObject
	{
		[XmlElement("account_ext_no")]
		public string AccountExtNo
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

		[XmlElement("amt")]
		public string Amt
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

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("inst_out_code")]
		public string InstOutCode
		{
			get;
			set;
		}

		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("payment_mark")]
		public string PaymentMark
		{
			get;
			set;
		}
	}
}
