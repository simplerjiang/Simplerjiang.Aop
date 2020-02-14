using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectOnlineQueryResponse : AopResponse
	{
		[XmlArray("address_info")]
		[XmlArrayItem("address_info")]
		public List<AddressInfo> AddressInfo
		{
			get;
			set;
		}

		[XmlElement("alias_name")]
		public string AliasName
		{
			get;
			set;
		}

		[XmlElement("bank_pid")]
		public string BankPid
		{
			get;
			set;
		}

		[XmlArray("bankcard_info")]
		[XmlArrayItem("bank_card_info")]
		public List<BankCardInfo> BankcardInfo
		{
			get;
			set;
		}

		[XmlElement("business_license")]
		public string BusinessLicense
		{
			get;
			set;
		}

		[XmlElement("business_license_type")]
		public string BusinessLicenseType
		{
			get;
			set;
		}

		[XmlArray("contact_info")]
		[XmlArrayItem("contact_info")]
		public List<ContactInfo> ContactInfo
		{
			get;
			set;
		}

		[XmlElement("isv_pid")]
		public string IsvPid
		{
			get;
			set;
		}

		[XmlArray("logon_id")]
		[XmlArrayItem("string")]
		public List<string> LogonId
		{
			get;
			set;
		}

		[XmlElement("mcc")]
		public string Mcc
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlArray("pay_code_info")]
		[XmlArrayItem("string")]
		public List<string> PayCodeInfo
		{
			get;
			set;
		}

		[XmlElement("service_phone")]
		public string ServicePhone
		{
			get;
			set;
		}

		[XmlElement("sign_bank_time")]
		public string SignBankTime
		{
			get;
			set;
		}

		[XmlArray("site_info")]
		[XmlArrayItem("site_info")]
		public List<SiteInfo> SiteInfo
		{
			get;
			set;
		}

		[XmlElement("unique_id_by_bank")]
		public string UniqueIdByBank
		{
			get;
			set;
		}

		[XmlElement("unique_id_by_isv")]
		public string UniqueIdByIsv
		{
			get;
			set;
		}
	}
}
