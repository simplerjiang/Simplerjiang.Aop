using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectQueryResponse : AopResponse
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

		[XmlElement("category_id")]
		public string CategoryId
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

		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("indirect_level")]
		public string IndirectLevel
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

		[XmlElement("org_pid")]
		public string OrgPid
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

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}
	}
}
