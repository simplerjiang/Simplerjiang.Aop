using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCertifyInfoApplyModel : AopObject
	{
		[XmlElement("agent_auth_letter_picture")]
		public string AgentAuthLetterPicture
		{
			get;
			set;
		}

		[XmlElement("agent_cert_card_assist_picture")]
		public string AgentCertCardAssistPicture
		{
			get;
			set;
		}

		[XmlElement("agent_cert_card_info_picture")]
		public string AgentCertCardInfoPicture
		{
			get;
			set;
		}

		[XmlElement("agent_cert_expired_date")]
		public string AgentCertExpiredDate
		{
			get;
			set;
		}

		[XmlElement("agent_cert_no")]
		public string AgentCertNo
		{
			get;
			set;
		}

		[XmlElement("agent_cert_type")]
		public string AgentCertType
		{
			get;
			set;
		}

		[XmlElement("agent_name")]
		public string AgentName
		{
			get;
			set;
		}

		[XmlElement("biz_from")]
		public string BizFrom
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

		[XmlElement("legal_cert_card_assist_picture")]
		public string LegalCertCardAssistPicture
		{
			get;
			set;
		}

		[XmlElement("legal_cert_card_info_picture")]
		public string LegalCertCardInfoPicture
		{
			get;
			set;
		}

		[XmlElement("legal_cert_expired_date")]
		public string LegalCertExpiredDate
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

		[XmlElement("legal_cert_type")]
		public string LegalCertType
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

		[XmlElement("org_address")]
		public string OrgAddress
		{
			get;
			set;
		}

		[XmlElement("org_business_scope")]
		public string OrgBusinessScope
		{
			get;
			set;
		}

		[XmlElement("org_city")]
		public string OrgCity
		{
			get;
			set;
		}

		[XmlElement("org_country")]
		public string OrgCountry
		{
			get;
			set;
		}

		[XmlElement("org_main_cert_expired_date")]
		public string OrgMainCertExpiredDate
		{
			get;
			set;
		}

		[XmlElement("org_main_cert_no")]
		public string OrgMainCertNo
		{
			get;
			set;
		}

		[XmlElement("org_main_cert_picture")]
		public string OrgMainCertPicture
		{
			get;
			set;
		}

		[XmlElement("org_name")]
		public string OrgName
		{
			get;
			set;
		}

		[XmlElement("org_province")]
		public string OrgProvince
		{
			get;
			set;
		}

		[XmlElement("org_type")]
		public string OrgType
		{
			get;
			set;
		}

		[XmlElement("register_capital")]
		public string RegisterCapital
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
