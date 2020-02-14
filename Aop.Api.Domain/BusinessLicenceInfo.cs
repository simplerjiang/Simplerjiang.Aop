using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BusinessLicenceInfo : AopObject
	{
		[XmlElement("business_license_auth_pic")]
		public string BusinessLicenseAuthPic
		{
			get;
			set;
		}

		[XmlElement("business_license_city")]
		public string BusinessLicenseCity
		{
			get;
			set;
		}

		[XmlElement("business_license_indate")]
		public string BusinessLicenseIndate
		{
			get;
			set;
		}

		[XmlElement("business_license_is_three_in_one")]
		public bool BusinessLicenseIsThreeInOne
		{
			get;
			set;
		}

		[XmlElement("business_license_no")]
		public string BusinessLicenseNo
		{
			get;
			set;
		}

		[XmlElement("business_license_pic")]
		public string BusinessLicensePic
		{
			get;
			set;
		}

		[XmlElement("business_license_province")]
		public string BusinessLicenseProvince
		{
			get;
			set;
		}

		[XmlElement("business_scope")]
		public string BusinessScope
		{
			get;
			set;
		}

		[XmlElement("company_address")]
		public string CompanyAddress
		{
			get;
			set;
		}

		[XmlElement("company_name")]
		public string CompanyName
		{
			get;
			set;
		}

		[XmlElement("org_code_certificate_no")]
		public string OrgCodeCertificateNo
		{
			get;
			set;
		}

		[XmlElement("org_code_certificate_pic")]
		public string OrgCodeCertificatePic
		{
			get;
			set;
		}
	}
}
