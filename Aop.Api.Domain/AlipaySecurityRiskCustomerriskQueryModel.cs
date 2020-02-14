using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskCustomerriskQueryModel : AopObject
	{
		[XmlElement("bank_card_no")]
		public string BankCardNo
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

		[XmlElement("card_no")]
		public string CardNo
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

		[XmlElement("company_name")]
		public string CompanyName
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

		[XmlElement("mobile_no")]
		public string MobileNo
		{
			get;
			set;
		}

		[XmlElement("risk_type")]
		public string RiskType
		{
			get;
			set;
		}
	}
}
