using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserUserinfoShareResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("address_code")]
		public string AddressCode
		{
			get;
			set;
		}

		[XmlElement("alipay_user_id")]
		public string AlipayUserId
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

		[XmlElement("balance_freeze_type")]
		public string BalanceFreezeType
		{
			get;
			set;
		}

		[XmlElement("birthday")]
		public string Birthday
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

		[XmlElement("cert_type_value")]
		public string CertTypeValue
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

		[XmlElement("default_deliver_address")]
		public string DefaultDeliverAddress
		{
			get;
			set;
		}

		[XmlArray("deliver_address_list")]
		[XmlArrayItem("deliver_address")]
		public List<DeliverAddress> DeliverAddressList
		{
			get;
			set;
		}

		[XmlElement("deliver_area")]
		public string DeliverArea
		{
			get;
			set;
		}

		[XmlElement("deliver_city")]
		public string DeliverCity
		{
			get;
			set;
		}

		[XmlElement("deliver_fullname")]
		public string DeliverFullname
		{
			get;
			set;
		}

		[XmlElement("deliver_mobile")]
		public string DeliverMobile
		{
			get;
			set;
		}

		[XmlElement("deliver_phone")]
		public string DeliverPhone
		{
			get;
			set;
		}

		[XmlElement("deliver_province")]
		public string DeliverProvince
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

		[XmlElement("family_name")]
		public string FamilyName
		{
			get;
			set;
		}

		[XmlElement("firm_name")]
		public string FirmName
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

		[XmlElement("is_balance_frozen")]
		public string IsBalanceFrozen
		{
			get;
			set;
		}

		[XmlElement("is_bank_auth")]
		public string IsBankAuth
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

		[XmlElement("is_certify_grade_a")]
		public string IsCertifyGradeA
		{
			get;
			set;
		}

		[XmlElement("is_id_auth")]
		public string IsIdAuth
		{
			get;
			set;
		}

		[XmlElement("is_licence_auth")]
		public string IsLicenceAuth
		{
			get;
			set;
		}

		[XmlElement("is_mobile_auth")]
		public string IsMobileAuth
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

		[XmlElement("phone")]
		public string Phone
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

		[XmlElement("real_name")]
		public string RealName
		{
			get;
			set;
		}

		[XmlElement("reduced_birthday")]
		public string ReducedBirthday
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

		[XmlElement("user_status")]
		public string UserStatus
		{
			get;
			set;
		}

		[XmlElement("user_type_value")]
		public string UserTypeValue
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
