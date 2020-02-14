using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Injured : AopObject
	{
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

		[XmlElement("damage_type")]
		public string DamageType
		{
			get;
			set;
		}

		[XmlElement("injured_identity")]
		public string InjuredIdentity
		{
			get;
			set;
		}

		[XmlElement("medical_assessor")]
		public Person MedicalAssessor
		{
			get;
			set;
		}

		[XmlElement("medical_surveyor")]
		public Person MedicalSurveyor
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
	}
}
