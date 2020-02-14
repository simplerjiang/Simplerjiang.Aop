using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserInfoShareResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("area")]
		public string Area
		{
			get;
			set;
		}

		[XmlElement("avatar")]
		public string Avatar
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

		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("college_name")]
		public string CollegeName
		{
			get;
			set;
		}

		[XmlElement("country_code")]
		public string CountryCode
		{
			get;
			set;
		}

		[XmlElement("degree")]
		public string Degree
		{
			get;
			set;
		}

		[XmlArray("deliver_addresses")]
		[XmlArrayItem("alipay_user_deliver_address")]
		public List<AlipayUserDeliverAddress> DeliverAddresses
		{
			get;
			set;
		}

		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("enrollment_time")]
		public string EnrollmentTime
		{
			get;
			set;
		}

		[XmlElement("firm_agent_person_cert_expiry_date")]
		public string FirmAgentPersonCertExpiryDate
		{
			get;
			set;
		}

		[XmlElement("firm_agent_person_cert_no")]
		public string FirmAgentPersonCertNo
		{
			get;
			set;
		}

		[XmlElement("firm_agent_person_cert_type")]
		public string FirmAgentPersonCertType
		{
			get;
			set;
		}

		[XmlElement("firm_agent_person_name")]
		public string FirmAgentPersonName
		{
			get;
			set;
		}

		[XmlElement("firm_legal_person_cert_expiry_date")]
		public string FirmLegalPersonCertExpiryDate
		{
			get;
			set;
		}

		[XmlElement("firm_legal_person_cert_no")]
		public string FirmLegalPersonCertNo
		{
			get;
			set;
		}

		[XmlElement("firm_legal_person_cert_type")]
		public string FirmLegalPersonCertType
		{
			get;
			set;
		}

		[XmlElement("firm_legal_person_name")]
		public string FirmLegalPersonName
		{
			get;
			set;
		}

		[XmlArray("firm_legal_person_pictures")]
		[XmlArrayItem("alipay_user_picture")]
		public List<AlipayUserPicture> FirmLegalPersonPictures
		{
			get;
			set;
		}

		[XmlArray("firm_pictures")]
		[XmlArrayItem("alipay_user_picture")]
		public List<AlipayUserPicture> FirmPictures
		{
			get;
			set;
		}

		[XmlElement("firm_type")]
		public string FirmType
		{
			get;
			set;
		}

		[XmlElement("gender")]
		public string Gender
		{
			get;
			set;
		}

		[XmlElement("graduation_time")]
		public string GraduationTime
		{
			get;
			set;
		}

		[XmlElement("is_balance_frozen")]
		public string IsBalanceFrozen
		{
			get;
			set;
		}

		[XmlElement("is_certified")]
		public string IsCertified
		{
			get;
			set;
		}

		[XmlElement("is_student_certified")]
		public string IsStudentCertified
		{
			get;
			set;
		}

		[XmlElement("license_expiry_date")]
		public string LicenseExpiryDate
		{
			get;
			set;
		}

		[XmlElement("license_no")]
		public string LicenseNo
		{
			get;
			set;
		}

		[XmlElement("member_grade")]
		public string MemberGrade
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("nick_name")]
		public string NickName
		{
			get;
			set;
		}

		[XmlElement("organization_code")]
		public string OrganizationCode
		{
			get;
			set;
		}

		[XmlElement("person_birthday")]
		public string PersonBirthday
		{
			get;
			set;
		}

		[XmlElement("person_cert_expiry_date")]
		public string PersonCertExpiryDate
		{
			get;
			set;
		}

		[XmlArray("person_pictures")]
		[XmlArrayItem("alipay_user_picture")]
		public List<AlipayUserPicture> PersonPictures
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement("profession")]
		public string Profession
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}

		[XmlElement("taobao_id")]
		public string TaobaoId
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

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}

		[XmlElement("user_status")]
		public string UserStatus
		{
			get;
			set;
		}

		[XmlElement("user_type")]
		public string UserType
		{
			get;
			set;
		}

		[XmlElement("zip")]
		public string Zip
		{
			get;
			set;
		}
	}
}
