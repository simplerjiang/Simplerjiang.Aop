using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MedicalHospitalDeptInfo : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("location")]
		public string Location
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

		[XmlElement("parent_name")]
		public string ParentName
		{
			get;
			set;
		}

		[XmlElement("partner_code")]
		public string PartnerCode
		{
			get;
			set;
		}
	}
}
