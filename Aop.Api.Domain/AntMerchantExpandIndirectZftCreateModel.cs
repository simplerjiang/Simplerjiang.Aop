using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectZftCreateModel : AopObject
	{
		[XmlElement("alias_name")]
		public string AliasName
		{
			get;
			set;
		}

		[XmlElement("alipay_logon_id")]
		public string AlipayLogonId
		{
			get;
			set;
		}

		[XmlArray("biz_cards")]
		[XmlArrayItem("settle_card_info")]
		public List<SettleCardInfo> BizCards
		{
			get;
			set;
		}

		[XmlElement("business_address")]
		public AddressInfo BusinessAddress
		{
			get;
			set;
		}

		[XmlElement("cert_image")]
		public string CertImage
		{
			get;
			set;
		}

		[XmlElement("cert_image_back")]
		public string CertImageBack
		{
			get;
			set;
		}

		[XmlElement("cert_name")]
		public string CertName
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlArray("contact_infos")]
		[XmlArrayItem("contact_info")]
		public List<ContactInfo> ContactInfos
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

		[XmlElement("invoice_info")]
		public MerchantInvoiceInfo InvoiceInfo
		{
			get;
			set;
		}

		[XmlElement("legal_cert_back_image")]
		public string LegalCertBackImage
		{
			get;
			set;
		}

		[XmlElement("legal_cert_front_image")]
		public string LegalCertFrontImage
		{
			get;
			set;
		}

		[XmlElement("legal_cert_no")]
		public string LegalCertNo
		{
			get;
			set;
		}

		[XmlElement("legal_name")]
		public string LegalName
		{
			get;
			set;
		}

		[XmlElement("license_auth_letter_image")]
		public string LicenseAuthLetterImage
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

		[XmlElement("merchant_type")]
		public string MerchantType
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlArray("out_door_images")]
		[XmlArrayItem("string")]
		public List<string> OutDoorImages
		{
			get;
			set;
		}

		[XmlArray("qualifications")]
		[XmlArrayItem("industry_qualification_info")]
		public List<IndustryQualificationInfo> Qualifications
		{
			get;
			set;
		}

		[XmlArray("service")]
		[XmlArrayItem("string")]
		public List<string> Service
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

		[XmlElement("sign_time_with_isv")]
		public string SignTimeWithIsv
		{
			get;
			set;
		}

		[XmlArray("sites")]
		[XmlArrayItem("site_info")]
		public List<SiteInfo> Sites
		{
			get;
			set;
		}
	}
}
