using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossProdSubmerchantQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
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

		[XmlElement("business_license")]
		public string BusinessLicense
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

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("contact_email")]
		public string ContactEmail
		{
			get;
			set;
		}

		[XmlElement("contact_mobile")]
		public string ContactMobile
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("contact_phone")]
		public string ContactPhone
		{
			get;
			set;
		}

		[XmlElement("district_code")]
		public string DistrictCode
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

		[XmlElement("id_card")]
		public string IdCard
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

		[XmlElement("province_code")]
		public string ProvinceCode
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
