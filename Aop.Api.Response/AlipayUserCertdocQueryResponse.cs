using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCertdocQueryResponse : AopResponse
	{
		[XmlElement("driving_license")]
		public AlipayUserCertDocDrivingLicense DrivingLicense
		{
			get;
			set;
		}

		[XmlArray("driving_license_list")]
		[XmlArrayItem("alipay_user_cert_doc_driving_license")]
		public List<AlipayUserCertDocDrivingLicense> DrivingLicenseList
		{
			get;
			set;
		}

		[XmlElement("identity_card")]
		public AlipayUserCertDocIDCard IdentityCard
		{
			get;
			set;
		}

		[XmlArray("identity_card_list")]
		[XmlArrayItem("alipay_user_cert_doc_i_d_card")]
		public List<AlipayUserCertDocIDCard> IdentityCardList
		{
			get;
			set;
		}

		[XmlArray("passport_list")]
		[XmlArrayItem("alipay_user_cert_doc_passport")]
		public List<AlipayUserCertDocPassport> PassportList
		{
			get;
			set;
		}

		[XmlArray("self_vehicle_license_list")]
		[XmlArrayItem("alipay_user_cert_doc_vehicle_license")]
		public List<AlipayUserCertDocVehicleLicense> SelfVehicleLicenseList
		{
			get;
			set;
		}

		[XmlArray("vehicle_license_list")]
		[XmlArrayItem("alipay_user_cert_doc_vehicle_license")]
		public List<AlipayUserCertDocVehicleLicense> VehicleLicenseList
		{
			get;
			set;
		}
	}
}
